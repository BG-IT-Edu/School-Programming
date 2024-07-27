GO
CREATE DATABASE Mountains
GO

USE Mountains
GO

CREATE TABLE Continents (
    Id INT PRIMARY KEY,
    Name VARCHAR(255)
);
GO

INSERT INTO Continents (Id, Name)
VALUES
    (1, 'Asia'),
    (2, 'Europe'),
    (3, 'North America'),
    (4, 'South America');
GO

CREATE TABLE Mountains (
    Id INT PRIMARY KEY,
    Name VARCHAR(255),
    ContinentId INT,
    FOREIGN KEY (ContinentId) REFERENCES Continents(Id)
);
GO

INSERT INTO Mountains (Id, Name, ContinentId)
VALUES
    (1, 'Himalayas', 1),
    (2, 'Karakoram Range', 1),
    (3, 'Alps', 2),
    (4, 'Rocky Mountains', 3);
GO

CREATE TABLE Peaks (
    Id INT PRIMARY KEY,
    Name VARCHAR(255),
    Height INT,
    MountainId INT,
    FOREIGN KEY (MountainId) REFERENCES Mountains(Id)
);
GO

INSERT INTO Peaks (Id, Name, Height, MountainId)
VALUES
    (1, 'Everest', 8848, 1),
    (2, 'K2', 8611, 2),
    (3, 'Lhotse', 8516, 1),
    (4, 'Makalu', 8485, 1),
    (5, 'Mont Blanc', 4810, 3),
    (6, 'Denali', 6190, 4);
GO
