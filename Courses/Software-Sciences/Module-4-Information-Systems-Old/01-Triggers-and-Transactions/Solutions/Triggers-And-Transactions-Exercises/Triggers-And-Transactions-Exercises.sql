---- Create Table Logs
USE Bank
GO

CREATE TABLE Logs
(
     LogId INT PRIMARY KEY IDENTITY
   , AccountId INT FOREIGN KEY REFERENCES Accounts (Id)
   , OldSum DECIMAL (15, 2)
   , NewSum DECIMAL (15, 2)
)
GO

CREATE TRIGGER tr_InsertAccountInfo ON Accounts FOR UPDATE
AS
  DECLARE @newSum DECIMAL (15, 2) = (SELECT Balance FROM inserted)
  DECLARE @oldSum DECIMAL (15, 2) = (SELECT Balance FROM deleted)
  DECLARE @accountId INT = (SELECT Id FROM inserted)

  INSERT INTO Logs (AccountId, NewSum, OldSum) VALUES (@accountId, @newSum, @oldSum)
GO

UPDATE Accounts
SET Balance += 10
WHERE Id = 1

SELECT *
FROM Accounts WHERE Id = 1

SELECT *
FROM Logs


---- CREATE TABLE Emails
CREATE TABLE NotificationEmails
(
   Id INT PRIMARY KEY IDENTITY
   , Recipient INT FOREIGN KEY REFERENCES Accounts (Id)
   , [Subject] VARCHAR (50) NOT NULL
   , Body VARCHAR (MAX) 
)
GO

CREATE TRIGGER tr_LogEmail ON Logs FOR INSERT
AS
  DECLARE @accountId INT = (SELECT TOP (1) AccountId FROM inserted)
  DECLARE @oldSum DECIMAL (15, 2) = (SELECT TOP (1) OldSum FROM inserted)
  DECLARE @newSum DECIMAL (15, 2) = (SELECT TOP (1) NewSum FROM inserted)

  INSERT INTO NotificationEmails (Recipient, [Subject], Body) VALUES
  (
	  @accountId
	  , 'Balance change for account: ' + CAST(@accountId AS VARCHAR (20))
	  , 'On ' + CONVERT(VARCHAR (20), GETDATE(), 103)  + ' your balance was changed from ' + CAST(@oldSum AS VARCHAR(20)) + ' to ' + CAST(@newSum AS VARCHAR(20))
  )

  UPDATE Accounts 
  SET Balance += 100
  WHERE Id = 1
GO



---- Deposit Money
CREATE PROCEDURE usp_DepositMoney
(
     @accountId      INT
   , @moneyAmount DECIMAL(15, 4)
)
AS
    BEGIN TRANSACTION
	DECLARE @account INT = (SELECT Id FROM Accounts WHERE Id = @accountId)

	IF (@account IS NULL)
	BEGIN
	     ROLLBACK
		 RAISERROR ('Invalid account ID!', 16, 1)
		 RETURN
	END

	IF(@moneyAmount < 0)
	BEGIN
	     ROLLBACK
		 RAISERROR ('Negative amount!', 16, 1)
		 RETURN
	END

    UPDATE Accounts
      SET  
          Balance += @moneyAmount
    WHERE   
         Id = @accountId
    COMMIT
GO

EXECUTE usp_DepositMoney 1, 250
SELECT * FROM Accounts WHERE Id = 1
SELECT * FROM Logs
SELECT * FROM NotificationEmails
GO



---- Withdraw Money
CREATE PROCEDURE usp_WithdrawMoney
(
      @AccountId INT
	, @MoneyAmount DECIMAL (15, 4)
)
AS
  BEGIN TRANSACTION
      DECLARE @Account INT = (SELECT Id FROM Accounts WHERE Id = @AccountId)
      DECLARE @AccountBalance DECIMAL(15, 4) = (SELECT Balance FROM Accounts WHERE Id = @AccountId)

	IF (@Account IS NULL)
	BEGIN
	     ROLLBACK
		 RAISERROR ('Invalid account ID!', 16, 1)
		 RETURN
	END

	IF(@MoneyAmount < 0)
	BEGIN
	     ROLLBACK
		 RAISERROR ('Negative amount!', 16, 1)
		 RETURN
	END

	IF(@AccountBalance - @MoneyAmount < 0)
	BEGIN
	     ROLLBACK
		 RAISERROR ('Insufficient funds!', 16, 1)
		 RETURN
	END

	UPDATE Accounts
	  SET  
          Balance -= @MoneyAmount
    WHERE   
         Id = @AccountId
  COMMIT
GO

EXECUTE usp_WithdrawMoney 1, 20
SELECT * FROM Accounts WHERE Id = 1
SELECT * FROM Logs
SELECT * FROM NotificationEmails
GO


---- Money Transfer
CREATE PROCEDURE usp_TransferMoney 
(
      @SenderId INT
	, @ReceiverId INT
	, @Amount DECIMAL (15, 4)
)
AS
  BEGIN TRANSACTION
      EXECUTE dbo.usp_WithdrawMoney @SenderId, @Amount
      EXECUTE dbo.usp_DepositMmoney @ReceiverId, @Amount
  COMMIT
GO

SELECT Id AS [AccountId], AccountHolderId, Balance FROM Accounts
WHERE Id = 1 OR Id = 2
EXECUTE usp_DepositMoney 1, 2, 100
GO

----
CREATE PROCEDURE usp_TransferMoney(@SenderId INT, @ReceiverId INT, @Amount DECIMAL(15, 4))
AS
BEGIN
	DECLARE @targetSender INT = (SELECT Id FROM [dbo].[Accounts] AS a WHERE a.[Id] = @SenderId)
	DECLARE @targetReciver INT = (SELECT Id FROM [dbo].[Accounts] AS a WHERE a.[Id] = @ReceiverId)
	
	IF(@targetReciver IS NULL OR @targetSender IS NULL)
	BEGIN
		ROLLBACK
		RAISERROR('Invalid Id Parameter', 16, 1)
		RETURN
	END
	
	IF(@Amount < 0)
	BEGIN
		ROLLBACK
		RAISERROR('Invalid amount of money', 16, 2)
		RETURN
	END
	
	EXEC dbo.usp_WithdrawMoney @targetSender, @Amount
	EXEC dbo.usp_DepositMoney @targetReciver, @Amount
END
GO


---- Massive Shopping
-- Items with Level 11 & 12 & 19-21

DECLARE @userGameId INT = (SELECT Id FROM UsersGames 
							WHERE GameId = (SELECT Id FROM Games WHERE Name = 'Safflower')
								AND UserId = (SELECT Id FROM Users WHERE Username = 'Stamat')
							)
DECLARE @downLevel INT, @upLevel INT, @allItemsPrice MONEY

DECLARE @currentCash MONEY = (SELECT Cash FROM UsersGames WHERE Id = @userGameId)
DECLARE @userLevel INT = (SELECT Level FROM UsersGames WHERE Id = @userGameId)

-- BYIING ITEMS FROM 11th AND 12th LEVEL

SET @downLevel = 11
SET @upLevel = 12
SET @allItemsPrice = (SELECT SUM(Price) FROM Items WHERE MinLevel BETWEEN @downLevel AND @upLevel)

IF (@allItemsPrice <= @currentCash AND @userLevel >= @upLevel)
BEGIN
	BEGIN TRANSACTION
	UPDATE UsersGames
	SET Cash -= @allItemsPrice
	WHERE Id = @userGameId

	IF (@@ROWCOUNT <> 1)
		ROLLBACK
	ELSE
	BEGIN
		INSERT INTO UserGameItems (ItemId, UserGameId) 
		(SELECT Id, @userGameId FROM Items WHERE MinLevel BETWEEN @downLevel AND @upLevel)
		COMMIT
	END
END

-- BYIING ITEMS FROM 19th AND 21th LEVEL

SET @downLevel = 19
SET @upLevel = 21
SET @allItemsPrice = (SELECT SUM(Price) FROM Items WHERE MinLevel BETWEEN @downLevel AND @upLevel)
SET @currentCash = (SELECT Cash FROM UsersGames WHERE Id = @userGameId)

IF (@allItemsPrice <= @currentCash AND @userLevel >= @upLevel)
BEGIN
	BEGIN TRANSACTION
	UPDATE UsersGames
	SET Cash -= @allItemsPrice
	WHERE Id = @userGameId

	IF (@@ROWCOUNT <> 1)
		ROLLBACK
	ELSE
	BEGIN
		INSERT INTO UserGameItems (ItemId, UserGameId) 
    (SELECT Id, @userGameId FROM Items WHERE MinLevel BETWEEN @downLevel AND @upLevel)
		COMMIT
	END
END

-- SELECT THE PURCHASED ITEMS

SELECT 
	i.Name
FROM Items AS i
JOIN UserGameItems AS ugi
ON ugi.ItemId = i.Id
JOIN UsersGames AS ug
ON ug.Id = ugi.UserGameId AND ug.Id = @userGameId
ORDER BY i.Name ASC
GO



---- Employees with Three Projects
CREATE PROCEDURE usp_AssignProject
(
    @employeeId INT
	, @projectID INT
)
AS

BEGIN TRANSACTION;

    DECLARE @employee INT=
    (
        SELECT  
             EmployeeID
        FROM  
             Employees
        WHERE EmployeeID = @employeeId
    );
    
    DECLARE @project INT=
    (
        SELECT  
             ProjectID
        FROM  
             Projects
        WHERE ProjectID = @projectId
    );
    
    DECLARE @projectsCount INT=
    (
        SELECT  
             COUNT(*)
        FROM  
             EmployeesProjects
        WHERE EmployeeID = @employeeId
    );
    
    IF(@employee IS NULL
       OR @project IS NULL)
        BEGIN
            ROLLBACK;
            RAISERROR('Invalid Employee ID or Project ID.', 16, 1);
            RETURN;
    END;
    
    IF(@projectsCount >= 3)
        BEGIN
            ROLLBACK;
            RAISERROR('The employee has too many projects!', 16, 2);
            RETURN;
    END;
    
    INSERT INTO EmployeesProjects
    (
         EmployeeID
       , ProjectID
    )
    VALUES (@employeeId, @projectID);
COMMIT;
GO


---- Delete Employees
CREATE TABLE Deleted_Employees
(
      EmployeeId INT PRIMARY KEY 
	, FirstName VARCHAR(50)
	, MiddleName VARCHAR (50)
	, LastName VARCHAR (50)
	, JobTitle VARCHAR (50)
	, DepartmentId INT
	, Salary DECIMAL (15, 2)
)
GO

CREATE TRIGGER tr_DeletedEmployees ON Employees FOR DELETE
AS
BEGIN
    INSERT INTO Deleted_Employees (FirstName, MiddleName, LastName, JobTitle,     DepartmentId, Salary)
    SELECT FirstName, MiddleName, LastName, JobTitle, DepartmentId, Salary FROM deleted
END