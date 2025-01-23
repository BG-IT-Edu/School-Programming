CREATE DATABASE StudentsDb;
GO

USE StudentsDb;
GO

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) NOT NULL,
    Grade DECIMAL(5, 2) NOT NULL
);
GO

INSERT INTO Students (Name, Grade)
VALUES 
    ('John', 4.50),
    ('Alice', 3.55),
    ('David', 5.50),
    ('Emily', 3.25),
    ('Michael', 6.00),
    ('Sophia', 4.50),
    ('James', 6.00),
    ('Olivia', 3.50),
    ('Benjamin', 5.75),
    ('Emma', 4.50),
    ('Alexander', 5.60),
    ('Ava', 5.75),
    ('William', 3.00),
    ('Mia', 4.20),
    ('Elijah', 5.00),
    ('Charlotte', 3.95),
    ('Daniel', 4.60),
    ('Amelia', 5.20),
    ('Matthew', 4.50),
    ('Harper', 5.65),
    ('Jackson', 6.00),
    ('Evelyn', 4.35),
    ('Sebastian', 5.95),
    ('Abigail', 3.70),
    ('Sophie', 4.85);
GO