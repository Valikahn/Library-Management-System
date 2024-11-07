-- Create the LibraryDB database
CREATE DATABASE IF NOT EXISTS LibraryDB;
USE LibraryDB;

-- Create the Books table
CREATE TABLE IF NOT EXISTS Books (
    BookID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Author VARCHAR(255) NOT NULL,
    PublicationYear INT,
    Genre VARCHAR(100)
);

-- (Optional) Insert initial data
INSERT INTO Books (Title, Author, PublicationYear, Genre) VALUES
('1984', 'George Orwell', 1949, 'Dystopian'),
('To Kill a Mockingbird', 'Harper Lee', 1960, 'Classic'),
('The Great Gatsby', 'F. Scott Fitzgerald', 1925, 'Classic');
