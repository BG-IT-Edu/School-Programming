INSERT INTO Users (FirstName, LastName, Email, PhoneNumber)
VALUES ('Ivan', 'Ivanov', 'ivan@example.com', '0888123456');

INSERT INTO Users (FirstName, LastName, Email, PhoneNumber)
VALUES ('Peter', 'Petrov', 'petar@example.com', '0888234567');

INSERT INTO Categories ([Name], [Description])
VALUES ('Electronics', 'Products with electronic components');

INSERT INTO Categories ([Name], [Description])
VALUES ('Mobile Devices', 'Smartphones and accessories');

INSERT INTO Products ([Name], [Description], Price, StockQuantity, CategoryId)
VALUES ('Laptop', 'Powerful laptop with a fast processor', 1500, 10, 1);

INSERT INTO Products ([Name], [Description], Price, StockQuantity, CategoryId)
VALUES ('Smartphone', 'Smartphone with high camera resolution', 800, 15, 1);

INSERT INTO Products ([Name], [Description], Price, StockQuantity, CategoryId)
VALUES ('Headphones', 'High-quality over-ear headphones', 120, 25, 1);

INSERT INTO Products ([Name], [Description], Price, StockQuantity, CategoryId)
VALUES ('Smartwatch', 'Fitness and health monitoring smartwatch', 150, 20, 1);

INSERT INTO OrderItems (ProductId, Quantity, Subtotal)
VALUES (1, 5, 5 * 1500), 
	   (2, 6, 800),
	   (3, 3, 3 * 120),
	   (4, 4, 4 * 150)

INSERT INTO Orders (UserId, OrderDate, TotalAmount, ShippingAddress)
VALUES (1, '2023-01-05', 7500, 'First Street 5, Sofia');

INSERT INTO Orders (UserId, OrderDate, TotalAmount, ShippingAddress)
VALUES (2, '2023-02-10', 800, 'Second Street 10, Sofia');

INSERT INTO Reviews (ProductId, UserId, Rating, Comment)
VALUES (1, 1, 5, 'Great laptop with fast performance.');

INSERT INTO Reviews (ProductId, UserId, Rating, Comment)
VALUES (1, 2, 4, 'Solid laptop, but a bit heavy.');

INSERT INTO Reviews (ProductId, UserId, Rating, Comment)
VALUES (2, 1, 5, 'Amazing camera quality on this smartphone.');

INSERT INTO Reviews (ProductId, UserId, Rating, Comment)
VALUES (2, 2, 5, 'Sleek design and powerful features.');
