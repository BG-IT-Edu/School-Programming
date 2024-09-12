CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber(@MinSalary DECIMAL(18,4))
AS
BEGIN
	SELECT FirstName, LastName 
	FROM Employees
	WHERE Salary >= @MinSalary
END