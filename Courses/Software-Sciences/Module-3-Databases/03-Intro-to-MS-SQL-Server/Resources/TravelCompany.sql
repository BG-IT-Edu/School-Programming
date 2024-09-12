CREATE DATABASE TravelCompany;
GO

USE TravelCompany;
GO

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    Phone NVARCHAR(15)
);
GO

CREATE TABLE Destinations (
    DestinationID INT PRIMARY KEY IDENTITY(1,1),
    City NVARCHAR(50),
    Country NVARCHAR(50),
    Description TEXT
);
GO

CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    DestinationID INT,
    BookingDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (DestinationID) REFERENCES Destinations(DestinationID)
);
GO

CREATE TABLE Flights (
    FlightID INT PRIMARY KEY IDENTITY(1,1),
    DestinationID INT,
    FlightNumber NVARCHAR(10),
    DepartureDate DATETIME,
    ArrivalDate DATETIME,
    FOREIGN KEY (DestinationID) REFERENCES Destinations(DestinationID)
);
GO

CREATE TABLE Hotels (
    HotelID INT PRIMARY KEY IDENTITY(1,1),
    DestinationID INT,
    HotelName NVARCHAR(100),
    Rating INT,
    FOREIGN KEY (DestinationID) REFERENCES Destinations(DestinationID)
);
GO

INSERT INTO Customers (FirstName, LastName, Email, Phone) VALUES
('John', 'Doe', 'john.doe@example.com', '555-0101'),
('Jane', 'Smith', 'jane.smith@example.com', '555-0102'),
('Alice', 'Johnson', 'alice.johnson@example.com', '555-0103'),
('Bob', 'Lee', 'bob.lee@example.com', '555-0104'),
('Carol', 'Taylor', 'carol.taylor@example.com', '555-0105'),
('David', 'Brown', 'david.brown@example.com', '555-0106'),
('Emma', 'Davis', 'emma.davis@example.com', '555-0107'),
('Frank', 'Miller', 'frank.miller@example.com', '555-0108'),
('Grace', 'Wilson', 'grace.wilson@example.com', '555-0109'),
('Henry', 'Moore', 'henry.moore@example.com', '555-0110');

INSERT INTO Destinations (City, Country, Description) VALUES
('Paris', 'France', 'The city of lights and love.'),
('New York', 'USA', 'The city that never sleeps.'),
('Tokyo', 'Japan', 'A blend of the traditional and the ultra-modern.'),
('London', 'United Kingdom', 'Rich in history and culture.'),
('Sydney', 'Australia', 'Known for its Opera House and Harbour Bridge.'),
('Cairo', 'Egypt', 'Home of ancient wonders of the world.'),
('Rio de Janeiro', 'Brazil', 'Famous for its carnival and Copacabana.'),
('Cape Town', 'South Africa', 'Known for its stunning landscape and history.'),
('Berlin', 'Germany', 'A city known for its art and Berlin Wall.'),
('Barcelona', 'Spain', 'Famous for its architecture and art scenes.');

INSERT INTO Bookings (CustomerID, DestinationID, BookingDate) VALUES
(1, 1, '2023-06-15'),
(2, 2, '2023-06-16'),
(3, 3, '2023-06-17'),
(4, 4, '2023-06-18'),
(5, 5, '2023-06-19'),
(6, 6, '2023-06-20'),
(7, 7, '2023-06-21'),
(8, 8, '2023-06-22'),
(9, 9, '2023-06-23'),
(10, 10, '2023-06-24');

INSERT INTO Flights (DestinationID, FlightNumber, DepartureDate, ArrivalDate) VALUES
(1, 'FL100', '2023-07-01 08:00:00', '2023-07-01 12:00:00'),
(2, 'FL200', '2023-07-02 09:00:00', '2023-07-02 11:00:00'),
(3, 'FL300', '2023-07-03 07:00:00', '2023-07-03 09:30:00'),
(4, 'FL400', '2023-07-04 06:00:00', '2023-07-04 08:00:00'),
(5, 'FL500', '2023-07-05 09:30:00', '2023-07-05 10:30:00'),
(6, 'FL600', '2023-07-06 05:00:00', '2023-07-06 08:00:00'),
(7, 'FL700', '2023-07-07 04:00:00', '2023-07-07 06:00:00'),
(8, 'FL800', '2023-07-08 03:30:00', '2023-07-08 05:30:00'),
(9, 'FL900', '2023-07-09 07:00:00', '2023-07-09 09:00:00'),
(10, 'FL1000', '2023-07-10 08:00:00', '2023-07-10 12:00:00');

INSERT INTO Hotels (DestinationID, HotelName, Rating) VALUES
(1, 'Hotel Paris', 5),
(2, 'The Big Apple Hotel', 4),
(3, 'Tokyo Stay', 3),
(4, 'London Inn', 5),
(5, 'Sydney Harbor Hotel', 4),
(6, 'Cairo Sands', 3),
(7, 'Rio Resort', 4),
(8, 'Cape Town Lodge', 5),
(9, 'Berlin Bed & Breakfast', 3),
(10, 'Barcelona Suites', 4);
