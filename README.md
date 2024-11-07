# Library Management System

## Session 8 - Small C# Project

### Scenario: Library Management System
You are tasked with developing a Library Management System that allows users to manage a collection of books in a small library. The system should enable users to add, update, delete, and view books in the library. This will require using an SQL database to store information about each book.

### Requirements
1.	Classes: Implement three main classes to model the system:
* Book: Represents a book in the library.
* Library: Manages a collection of Book objects and provides methods to add, update, delete, and view books.
* DatabaseHandler: Handles interactions with the SQL database, including creating tables, connecting to the database, and executing SQL queries.

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
	* AddBook(Book book): Adds a new book to the database.
	* UpdateBook(int bookId, Book updatedBook): Updates the details of an existing book.
	* DeleteBook(int bookId): Removes a book from the database.
	* GetAllBooks(): Retrieves and displays all books.
	* SearchBooksByTitle(string title): Searches for books by their title.

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
