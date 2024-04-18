CREATE TABLE Authors (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    BirthYear INT
);

INSERT INTO Authors (Id, Name, BirthYear) VALUES
(1, 'Stephen King', 1947),
(2, 'J.K. Rowling', 1965),
(3, 'J.R.R. Tolkien', 1892),
(4, 'Jane Austen', 1775),
(5, 'Agatha Christie', 1890),
(6, 'F. Scott Fitzgerald', 1896),
(7, 'Mark Twain', 1835),
(8, 'Harper Lee', 1926),
(9, 'Oscar Wilde', 1854),
(10, 'Gabriel Garcia Marquez', 1927);

CREATE TABLE Books (
    Id INT PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    AuthorId INT,
    Genre NVARCHAR(100),
    PublishedYear INT,
    FOREIGN KEY (AuthorId) REFERENCES Authors(Id)
);

INSERT INTO Books (Id, Title, AuthorId, Genre, PublishedYear) VALUES
(1, 'It', 1, 'Horror', 1986),
(2, 'The Shining', 1, 'Horror', 1977),
(3, 'Harry Potter and the Philosopher''s Stone', 2, 'Fantasy', 1997),
(4, 'Harry Potter and the Chamber of Secrets', 2, 'Fantasy', 1998),
(5, 'The Lord of the Rings', 3, 'Fantasy', 1954),
(6, 'The Hobbit', 3, 'Fantasy', 1937),
(7, 'Pride and Prejudice', 4, 'Romance', 1813),
(8, 'Murder on the Orient Express', 5, 'Crime', 1934),
(9, 'And Then There Were None', 5, 'Crime', 1939),
(10, 'The Great Gatsby', 6, 'Tragedy', 1925),
(11, 'Tender Is the Night', 6, 'Romance', 1934),
(12, 'The Adventures of Tom Sawyer', 7, 'Adventure', 1876),
(13, 'To Kill a Mockingbird', 8, 'Novel', 1960),
(14, 'The Picture of Dorian Gray', 9, 'Novel', 1890),
(15, 'Love in the Time of Cholera', 10, 'Romance', 1985);