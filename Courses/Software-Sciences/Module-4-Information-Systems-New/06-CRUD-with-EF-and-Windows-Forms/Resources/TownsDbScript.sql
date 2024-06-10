CREATE DATABASE TownsDb;
GO

USE TownsDb;
GO

CREATE TABLE Towns (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);
GO

INSERT INTO Towns (Name) VALUES
(N'Благоевград'),
(N'Бургас'),
(N'Варна'),
(N'Велико Търново'),
(N'Видин'),
(N'Враца'),
(N'Габрово'),
(N'Добрич'),
(N'Кърджали'),
(N'Кюстендил'),
(N'Ловеч'),
(N'Монтана'),
(N'Пазарджик'),
(N'Плевен'),
(N'Перник'),
(N'Пловдив'),
(N'Разград'),
(N'Русе'),
(N'Силистра'),
(N'Сливен'),
(N'Смолян'),
(N'София'),
(N'Стара Загора'),
(N'Търговище'),
(N'Хасково'),
(N'Шумен'),
(N'Ямбол');
GO