﻿CREATE DATABASE CountriesDb;
GO

USE CountriesDb;
GO

CREATE TABLE Countries (
    CountryId INT PRIMARY KEY IDENTITY(1,1),
    CountryName NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Towns (
    TownId INT PRIMARY KEY IDENTITY(1,1),
    TownName NVARCHAR(100) NOT NULL,
    CountryId INT,
    FOREIGN KEY (CountryId) REFERENCES Countries(CountryId)
);
GO

INSERT INTO Countries (CountryName) VALUES 
(N'САЩ'), 
(N'Канада'), 
(N'Германия'), 
(N'Франция'), 
(N'Италия'), 
(N'Испания'), 
(N'Великобритания'), 
(N'Австралия'), 
(N'Япония'), 
(N'Бразилия');
GO

INSERT INTO Towns (TownName, CountryId) VALUES 
(N'Ню Йорк', 1), 
(N'Лос Анджелис', 1), 
(N'Чикаго', 1), 
(N'Хюстън', 1), 
(N'Финикс', 1),
(N'Торонто', 2), 
(N'Ванкувър', 2), 
(N'Монреал', 2), 
(N'Калгари', 2), 
(N'Отава', 2),
(N'Берлин', 3), 
(N'Хамбург', 3), 
(N'Мюнхен', 3), 
(N'Кьолн', 3), 
(N'Франкфурт', 3),
(N'Париж', 4), 
(N'Марсилия', 4), 
(N'Лион', 4), 
(N'Тулуза', 4), 
(N'Ница', 4),
(N'Рим', 5), 
(N'Милано', 5), 
(N'Неапол', 5), 
(N'Торино', 5), 
(N'Палермо', 5),
(N'Мадрид', 6), 
(N'Барселона', 6), 
(N'Валенсия', 6), 
(N'Севиля', 6), 
(N'Сарагоса', 6),
(N'Лондон', 7), 
(N'Бирмингам', 7), 
(N'Манчестър', 7), 
(N'Глазгоу', 7), 
(N'Ливърпул', 7),
(N'Сидни', 8), 
(N'Мелбърн', 8), 
(N'Бризбейн', 8), 
(N'Пърт', 8), 
(N'Аделаида', 8),
(N'Токио', 9), 
(N'Осака', 9), 
(N'Нагоя', 9), 
(N'Сапоро', 9), 
(N'Фукуока', 9),
(N'Сао Пауло', 10), 
(N'Рио де Жанейро', 10), 
(N'Бразилия', 10), 
(N'Салвадор', 10), 
(N'Форталеза', 10);
GO