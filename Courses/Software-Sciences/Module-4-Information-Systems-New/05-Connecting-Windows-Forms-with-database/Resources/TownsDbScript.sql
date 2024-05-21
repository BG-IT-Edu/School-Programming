CREATE TABLE Towns (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

INSERT INTO Towns (Name)
VALUES
    ('Blagoevgrad'),
    ('Burgas'),
    ('Varna'),
    ('Veliko Tarnovo'),
    ('Vidin'),
    ('Vratsa'),
    ('Gabrovo'),
    ('Dobrich'),
    ('Kardzhali'),
    ('Kyustendil'),
    ('Lovech'),
    ('Montana'),
    ('Pazardzhik'),
    ('Pleven'),
    ('Pernik'),
    ('Plovdiv'),
    ('Razgrad'),
    ('Ruse'),
    ('Silistra'),
    ('Sliven'),
    ('Smolyan'),
    ('Sofia'),
    ('Stara Zagora'),
    ('Targovishte'),
    ('Haskovo'),
    ('Shumen'),
    ('Yambol');