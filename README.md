﻿<div align="center">
    <a href="https://github.com/Valikahn/Library-Management-System" target="_blank">
        <img alt="lamp" src="https://github.com/Valikahn/Library-Management-System/blob/master/img/lms_img.png">
    </a>
</div>


# Library Management System

### Session 8 - Small C# Project

Program Version:  24.11.03<br />
Written by:  Neil Jamieson [Licence](#licence)<br />
As Part Of:  Software Development - Object Oriented Programming

### Scenario: Library Management System
You are tasked with developing a Library Management System that allows users to manage a collection of books in a small library. The system should enable users to add, update, delete, and view books in the library. This will require using an SQL database to store information about each book.

### Requirements

1.	Classes: Implement three main classes to model the system:
* Book: Represents a book in the library.
* Library: Manages a collection of Book objects and provides methods to add, update, delete, and view books.
* [1] DatabaseHandler: Handles interactions with the SQL database, including creating tables, connecting to the database, and executing SQL queries.

2.	Database:
* Create an SQL database named LibraryDB.
* Create a table named Books with the following columns:
	* BookID (Primary Key, Integer, Auto-increment)
	* Title (Text, not null)
	* Author (Text, not null)
	* PublicationYear (Integer)
	* Genre (Text)

3.	Functional Requirements:
* The Library class should have methods to:
	* [C] AddBook(Book book): Adds a new book to the database. [1]
	* [R] GetAllBooks(): Retrieves and displays all books. [2]
	* [U] UpdateBook(int bookId, Book updatedBook): Updates the details of an existing book.
	* [D] DeleteBook(int bookId): Removes a book from the database.
	* [S] SearchBooksByTitle(string title): Searches for books by their title.

4.	Programming Tasks:
	* Implement the Book class with properties for Title, Author, PublicationYear, and Genre.
	* In Library, create methods to interact with the DatabaseHandler class and perform CRUD operations.
	* In DatabaseHandler, create methods to connect to the SQL database, execute SQL commands, and retrieve data.

5.	Sample Interaction:
* When the application runs, display a menu with options to:
	* Add a new book.
	* Update book details.
	* Delete a book.
	* View all books.
	* Search for a book by title.

6.	Error Handling and Validation:
* Ensure that all user inputs are validated.
* Handle database connection issues gracefully.

### Additional Tips
**Encapsulation:** Make each class responsible for specific tasks and ensure that the Library class only interacts with the DatabaseHandler for database operations.

**Abstraction:** Abstract database-related code in DatabaseHandler so that students understand the separation of responsibilities.

**Inheritance and Polymorphism:** Though optional, you could add a base class or interface for different types of items in the library (e.g., MediaItem with subclasses Book, Magazine, etc.) for students to explore these OOP principles.

## Bugs & Issues
Please let me know if there is any bugs or issues with this script.
* Issues: <a href="https://github.com/Valikahn/Library-Management-System/issues">Via GitHub</a>

## Licence
Licensed under the GPLv3 License.
Copyright (C) 2024 Neil Jamieson

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.<br /><br />
This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.<br /><br />
You should have received a copy of the GNU General Public License along with this program. If not, see <a href="https://www.gnu.org/licenses/gpl-3.0.en.html">GNU General Public License</a>.<br />

## References
<a href="https://csharp.hotexamples.com/examples/MySql.Data.MySqlClient/MySqlException/-/php-mysqlexception-class-examples.html" target="_blank">[1]</a> C# (CSharp) MySql.Data.MySqlClient MySqlException Examples<br />
<a href="https://stackoverflow.com/questions/48478323/c-sharp-how-to-set-a-fix-field-width-using-string-interpolation" target="_blank">[2]</a> C# how to set a fix field width using string interpolation