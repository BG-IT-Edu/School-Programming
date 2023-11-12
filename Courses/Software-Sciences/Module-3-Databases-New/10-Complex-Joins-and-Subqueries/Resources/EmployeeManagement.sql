CREATE DATABASE EmployeeManagement

GO
USE EmployeeManagement
GO

CREATE TABLE Departments (
	Id INT PRIMARY KEY,
	[Name] NVARCHAR(50)
)

INSERT INTO Departments
VALUES 
(1, 'Finance'),
(2, 'Sales'),
(3, 'Research and Development'),
(4, 'Human Resources')

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(255),
    LastName VARCHAR(255),
	Age INT,
    DepartmentId INT FOREIGN KEY REFERENCES Departments(Id)
)

INSERT INTO Employees
VALUES
    (1, 'George', 'Smith', 23, 1),
    (2, 'John', 'Wills', 41, 1),
    (3, 'Maria', 'Doe', 25, 1),
    (4, 'Emily', 'Wilson', 38, 1),
    (5, 'David', 'Wilson', 40, 1),
	(6, 'Ivan', 'Ivanov', 42, 2),
	(7, 'Peter', 'Johnson', 39, 3),
	(8, 'Simon', 'Georgiev', 31, 4),
	(9, 'Anton', 'Raichov', 39, 2)