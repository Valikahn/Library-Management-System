-- Create the database
CREATE DATABASE IF NOT EXISTS LibraryDB;
USE LibraryDB;

-- Create the table
CREATE TABLE IF NOT EXISTS Books (
    BookID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    AuthorFirstName VARCHAR(50) NOT NULL,
    AuthorLastName VARCHAR(50) NOT NULL,
    PublicationYear INT,
    Genre VARCHAR(50)
);