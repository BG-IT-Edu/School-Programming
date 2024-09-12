CREATE DATABASE OrderTracker

GO
USE OrderTracker
GO

CREATE TABLE Users (
    Id INT PRIMARY KEY,
    FirstName VARCHAR(255),
    LastName VARCHAR(255)
)

INSERT INTO Users (Id, FirstName, LastName)
VALUES
    (1, 'John', 'Smith'),
    (2, 'Jane', 'Doe'),
    (3, 'Michael', 'Johnson'),
    (4, 'Emily', 'Brown'),
    (5, 'Yordan', 'Ivanov'),
    (6, 'Maria', 'Georgieva'),
    (7, 'George', 'Williams'),
    (8, 'Ivan', 'Georgiev'),
    (9, 'Peter', 'Petrov'),
    (10, 'Ivan', 'Simeonov')

CREATE TABLE ProductTypes (
	Id INT PRIMARY KEY,
	[Name] NVARCHAR(50)
)

INSERT INTO ProductTypes
VALUES
	(1, 'Electronics'),
	(2, 'Furniture'),
	(3, 'Gardening'),
	(4, 'Home Appliance')

CREATE TABLE Products (
    Id INT PRIMARY KEY,
    [Name] NVARCHAR(255),
    Price DECIMAL(10, 2),
	TypeId INT FOREIGN KEY REFERENCES ProductTypes(Id)
)

INSERT INTO Products
VALUES
    (1, 'Phone', 510.99, 1),
    (2, 'TV', 2115.99, 1),
    (3, 'Chair', 12.49, 2),
    (4, 'Table', 149.99, 2),
    (5, 'Sofa', 1500.00, 2),
    (6, 'Refrigerator', 3425.00, 4),
    (7, 'Pruning shears', 25.15, 3),
    (8, 'Vegetable seeds', 8.52, 3),
    (9, 'Mulch', 4.55, 3)

CREATE TABLE Orders (
    Id INT PRIMARY KEY,
    UserId INT,
    ProductId INT,
    FOREIGN KEY (UserId) REFERENCES Users(Id),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
)

INSERT INTO Orders (Id, UserId, ProductId)
VALUES
    (1, 1, 1),
    (2, 2, 2),
    (3, 3, 3),
    (4, 4, 4),
    (5, 5, 5),
    (6, 5, 1),
    (7, 6, 4),
    (8, 7, 6),
    (9, 8, 7),
    (10, 9, 8),
    (11, 10, 9)