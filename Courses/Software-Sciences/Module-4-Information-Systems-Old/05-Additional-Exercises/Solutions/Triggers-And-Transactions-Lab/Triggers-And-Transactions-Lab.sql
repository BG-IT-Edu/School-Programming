CREATE DATABASE
BankTransactions
GO

USE BankTransactions
GO

CREATE TABLE Accounts
(
      AccountId INT PRIMARY KEY 
	, [NAME] VARCHAR (20)
	, Balance MONEY
)
GO
INSERT INTO Accounts (AccountId, [NAME], Balance) VALUES (1, 'Tom', 100)
INSERT INTO Accounts (AccountId, [NAME], Balance) VALUES (2, 'Jerry', 50)

-- Bank Transactions
CREATE PROCEDURE usp_SendMoney 
     @senderAccountId   INT
   , @receiverAccountId INT
   , @amount            MONEY
AS
    BEGIN TRANSACTION

        DECLARE @senderAccount INT=
        (
            SELECT AccountId
            FROM Accounts
            WHERE AccountId = @senderAccountId
        )
        DECLARE @receiverAccount INT=
        (
            SELECT AccountId
            FROM Accounts
            WHERE AccountId = @receiverAccountId
        )

        IF(@senderAccount IS NULL
           OR @receiverAccountId IS NULL)
            BEGIN
                ROLLBACK
                RAISERROR('Account doesn''t exist!', 16, 1)
                RETURN
        END

        DECLARE @currentAmount MONEY=
        (
            SELECT Balance
            FROM Accounts
            WHERE AccountId = @senderAccountId
        )

        IF(@currentAmount - @amount < 0)
            BEGIN
                ROLLBACK
                RAISERROR('Insufficient funds!', 16, 2)
                RETURN
        END

        UPDATE Accounts
          SET  
              Balance-=@amount
        WHERE   
             AccountId = @senderAccountId

        UPDATE Accounts
          SET  
              Balance+=@amount
        WHERE   
             AccountId = @receiverAccountId

        COMMIT
GO

SELECT *
FROM Accounts
GO
EXECUTE usp_SendMoney 2, 1, 40
GO


-- Trigger Accounts Delete
CREATE TRIGGER tr_AccountProtect ON Accounts
INSTEAD OF DELETE
AS

UPDATE Accounts SET IsDeleted = 1
FROM Accounts AS a JOIN deleted AS d on a.AccountId = d.AccountId
WHERE a.IsDeleted = 0
SELECT * FROM deleted

--DELETE FROM Accounts WHERE AccountId=1
SELECT * FROM Accounts


