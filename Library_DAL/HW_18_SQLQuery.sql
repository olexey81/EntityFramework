-- —“¬ќ–≈ЌЌя
--Create database HomeWork
-- таблиц€ б≥бл≥отекар≥в
CREATE TABLE Librarians (
    [Login] VARCHAR(50) NOT NULL PRIMARY KEY,
    [Password] VARCHAR(50) NOT NULL,
    Email VARCHAR(50) NOT NULL
)

-- таблиц€ тип≥в документ≥в
CREATE TABLE DocumentsTypes (
    DocTypeID INT IDENTITY(1, 1) PRIMARY KEY,
    TypeName VARCHAR(50) NOT NULL
)

-- таблиц€ читач≥в
CREATE TABLE Readers (
    [Login] VARCHAR(50) NOT NULL PRIMARY KEY,
    [Password] VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50),
    DocumentNumber VARCHAR(50) NOT NULL,
    DocumentType INT REFERENCES DocumentsTypes(DocTypeID)
)

-- таблиц€ автор≥в
CREATE TABLE Authors (
    AuthorID INT IDENTITY(1, 1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    MiddleName VARCHAR(50)
)


-- таблиц€ тип≥в видавничого коду
CREATE TABLE PublCodeTypes (
    PublCodeTypeID INT IDENTITY(1, 1) PRIMARY KEY,
    TypeName VARCHAR(50) NOT NULL
)


-- таблиц€ книг
CREATE TABLE Books (
    BookID INT IDENTITY(1, 1) PRIMARY KEY,
    Title VARCHAR(50) NOT NULL,
	Author INT NOT NULL REFERENCES Authors(AuthorID),
	PublCode VARCHAR(20) NOT NULL,
	PublCodeType INT REFERENCES PublCodeTypes(PublCodeTypeID),
	[Year] INT NOT NULL,
	Country VARCHAR(50) NOT NULL,
    City VARCHAR(50)
)


-- таблиц€ дл€ зв'€зку "many-to-many" м≥ж книгами та авторами
CREATE TABLE BooksAuthors (
	ID INT IDENTITY(1, 1) PRIMARY KEY,
    BookID INT REFERENCES Books(BookID) NOT NULL,
    AuthorID INT REFERENCES Authors(AuthorID) NOT NULL,
)




-- «јѕќ¬Ќ≈ЌЌя 

--б≥бл≥отекар≥
INSERT INTO Librarians ([Login], [Password], Email) VALUES ('mainLib', 'a09876', 'mainLib@lib.com.ua')
INSERT INTO Librarians ([Login], [Password], Email) VALUES ('middleLib', 'b09876', 'middleLib@lib.com.ua')
INSERT INTO Librarians ([Login], [Password], Email) VALUES ('youngLib', 'c09876', 'youngLib@lib.com.ua')

-- типи док≥в
INSERT INTO DocumentsTypes (TypeName) VALUES ('Passport')
INSERT INTO DocumentsTypes (TypeName) VALUES ('Driver License')
INSERT INTO DocumentsTypes (TypeName) VALUES ('ID card')
INSERT INTO DocumentsTypes (TypeName) VALUES ('Resident permission')

-- читач≥
INSERT INTO Readers ([Login], [Password], Email, FirstName, LastName, MiddleName, DocumentNumber, DocumentType)
	VALUES ('ad_dr', '123_ad', 'a.d@lib.com.ua', 'Adam', 'Driser', null, 'N12345', 2)
INSERT INTO Readers ([Login], [Password], Email, FirstName, LastName, MiddleName, DocumentNumber, DocumentType)
	VALUES ('ph_co', '234_pc', 'p.c@lib.com.ua', 'Phill', 'Colins', null, 'w23423', 1)
INSERT INTO Readers ([Login], [Password], Email, FirstName, LastName, MiddleName, DocumentNumber, DocumentType)
	VALUES ('pe_pe', '987_pp', 'p.p@lib.com.ua', 'Petro', 'Petrenko', 'Andriyovich', '789456', 3)
INSERT INTO Readers ([Login], [Password], Email, FirstName, LastName, MiddleName, DocumentNumber, DocumentType)
	VALUES ('va_ko', 'hjk_vk', 'v.k@lib.com.ua', 'Vasyl', 'Kovtun', 'Ivanovych', '654897', 3)
INSERT INTO Readers ([Login], [Password], Email, FirstName, LastName, MiddleName, DocumentNumber, DocumentType)
	VALUES ('pa_lu', '3e4_pl', 'p.l@lib.com.ua', 'Patrice', 'Lumumba', null, '0123456J', 4)

-- автори
INSERT INTO Authors (FirstName, LastName, MiddleName) VALUES ('J.K.', 'Rowling', NULL)
INSERT INTO Authors (FirstName, LastName, MiddleName) VALUES ('George', 'Orwell', NULL)
INSERT INTO Authors (FirstName, LastName, MiddleName) VALUES ('Mykova', 'Gogol', 'Vasylyovich')


-- типи видавничого коду
INSERT INTO PublCodeTypes (TypeName) VALUES ('ISBN')
INSERT INTO PublCodeTypes (TypeName) VALUES ('BBK')

-- книги
INSERT INTO Books (Title, Author, PublCode, PublCodeType, [Year], Country, City)
	VALUES ('Harry Potter and the Philosopher''s Stone', 1, '966-7047-39-3', 1, 1997, 'UK', 'London')
INSERT INTO Books (Title, Author, PublCode, PublCodeType, [Year], Country, City)
	VALUES ('1984', 2, '978-966-2355-57-4 ', 1, 1949, 'UK', 'London')
INSERT INTO Books (Title, Author, PublCode, PublCodeType, [Year], Country, City)
	VALUES ('Taras Bulba', 3, '966-663-179-2', 2, 1835, 'Ukraine', null)

-- зв'€зк≥ м≥ж книгами та авторами
INSERT INTO BooksAuthors (BookID, AuthorID) VALUES (1, 1)
INSERT INTO BooksAuthors (BookID, AuthorID) VALUES (2, 2)
INSERT INTO BooksAuthors (BookID, AuthorID) VALUES (3, 3)
INSERT INTO BooksAuthors (BookID, AuthorID) VALUES (2, 1) -- ну таке, дл€ прикладу )
INSERT INTO BooksAuthors (BookID, AuthorID) VALUES (3, 2)