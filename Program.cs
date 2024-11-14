using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Library_Management_System;
using Mysqlx.Crud;
namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------  CONNECTION STRING TO CONNECT TO THE DATABASE  --------------------//
            string connectionString = "Server=10.11.22.43;Port=3306;Database=LibraryDB;User=phpMyAdmin;Password=Enzc7Sqs8vSviiPx;";

            //--------------------  INITIALISE THE DATABASEHANDLER AND LIBRARY WITH THE CONNECTION STRING  --------------------//
            DatabaseHandler dbHandler = new DatabaseHandler(connectionString);
            Library library = new Library(dbHandler);

            //--------------------  MAIN LOOP FOR THE APPLICATION MENU  --------------------//
            bool exit = false;
            while (!exit)
            {
                //--------------------  DISPLAY THE MENU OPTIONS  --------------------//
                Console.WriteLine("\n##--- WELCOME TO THE LIBRARY MANAGEMENT SYSTEM ---##");
                Console.WriteLine("");
                Console.WriteLine("1. [C] ADD A NEW BOOK TO THE LIBRARY");
                Console.WriteLine("2. [R] VIEW ALL BOOKS");
                Console.WriteLine("3. [U] UPDATE BOOK DETAILS");
                Console.WriteLine("4. [D] DELETE A BOOK");
                Console.WriteLine("5. [S] SEARCH FOR A BOOK BY TITLE");
                Console.WriteLine("0. EXIT");
                Console.WriteLine("");
                Console.Write("SELECT AN OPTION USING NUMERICAL VALUES: ");

                //--------------------  READ USER INPUT FOR MENU CHOICE  --------------------//
                string choice = Console.ReadLine();
                Console.WriteLine();

                //--------------------  HANDLE USER CHOICE USING A SWITCH STATEMENT  --------------------//
                switch (choice)
                {
                    //--------------------  USER CHOOSES TO [C] ADD A BOOK TO THE DATABASE WITH THIS SWITCHCASE FUNCTION  --------------------//
                    case "1" or "c" or "C":
                        Console.Clear();
                        AddBook(library);
                        break;
                    //--------------------  USER CHOOSES TO [R] VIEW ALL BOOKS CURRENTLY IN THE DATABASE WITH THIS SWITCHCASE FUNCTION  --------------------//
                    case "2" or "r" or "R":
                        Console.Clear();
                        GetAllBooks(library);
                        break;
                    //--------------------  USER CHOOSES TO [U] UPDATE A BOOK IN THE DATABASE WITH THIS SWITCHCASE FUNCTION  --------------------//
                    case "3" or "u" or "U":
                        Console.Clear();
                        UpdateBook(library);
                        break;
                    //--------------------  USER CHOOSES TO [D] DELETE A BOOK FROM THE DATABASE WITH THIS SWITCHCASE FUNCTION  --------------------//

                    case "4" or "d" or "D":
                        Console.Clear();
                        DeleteBook(library);
                        break;
                    //--------------------  USER CHOOSES TO [S] SEARCH FOR A BOOK CURRENTLY IN THE DATABASE WITH THIS SWITCHCASE FUNCTION  --------------------//
                    case "5" or "s" or "S":
                        Console.Clear();
                        SearchBooks(library);
                        break;
                    //--------------------  SETS "BOOL (!EXIT)" FLAG TO TRUE ALLOWING THE WHILE LOOP TO EXIT AND THE APPLICATION TO END  --------------------//
                    case "0":
                        Console.Clear();
                        exit = true; 
                        Console.WriteLine("EXITING THE APPLICATION.  ADIOS AMIGO!");
                        break;
                    //--------------------  INVALID OPTION - PLEASE TRY AGAIN  --------------------//
                    default:
                        Console.Clear();
                        Console.WriteLine("INVALID OPTION. PLEASE SELECT A NUMBER BETWEEN 1 AND 6.");
                        Console.Clear();
                        break;
                }
            }
        }
        //--------------------  FUNCTION TO ADD A NEW BOOK  --------------------//
        static void AddBook(Library library)
        {
            Console.Clear();
            Console.WriteLine("##--- Add a New Book ---##");
            Console.WriteLine("");

            //--------------------  GET BOOK DETAILS FROM THE USER  --------------------//
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();
            //--------------------  VALIDATE TITLE  --------------------//
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Title cannot be empty.");
                return;
            }

            Console.Write("Enter Authors First Name: ");
            string authorFirstName = Console.ReadLine();
            //--------------------  VALIDATE AUTHOR  --------------------//
            if (string.IsNullOrWhiteSpace(authorFirstName))
            {
                Console.WriteLine("Author cannot be empty.");
                return;
            }

            Console.Write("Enter Authors Last Name: ");
            string authorLastName = Console.ReadLine();
            //--------------------  VALIDATE AUTHOR  --------------------//
            if (string.IsNullOrWhiteSpace(authorLastName))
            {
                Console.WriteLine("Author cannot be empty.");
                return;
            }

            Console.Write("Publication Year: ");
            string yearInput = Console.ReadLine();
            int publicationYear = 0;
            if (!string.IsNullOrWhiteSpace(yearInput))
            {
                //--------------------  VALIDATE YEAR INPUT  --------------------//
                if (int.TryParse(yearInput, out int year))
                {
                    publicationYear = year;
                }
                else
                {
                    Console.WriteLine("Invalid year. Please enter a valid integer.");
                    return;
                }
            }

            Console.Write("Genre: ");
            //--------------------  GET GENRE  --------------------//
            string genre = Console.ReadLine();

            //--------------------  CREATE A NEW BOOK OBJECT AND ADD IT TO THE LIBRARY  --------------------//
            Book newBook = new Book(title, authorFirstName, authorLastName, publicationYear, genre);
            library.AddBook(newBook);
        }

        //--------------------  FUNCTION TO DISPLAY ALL BOOKS IN DATABASE  --------------------//
        static void GetAllBooks(Library library)
        {
            Console.WriteLine("--- Display all Books ---");
            Console.WriteLine("");

            //--------------------  DISPLAY ALL BOOKS IN DATABASE  --------------------//
            library.ViewAllBooks();
        }

        //--------------------  FUNCTION TO UPDATE BOOK DETAILS  --------------------//
        static void UpdateBook(Library library)
        {
            Console.WriteLine("--- Update Book Details ---");
            Console.WriteLine("");

            //--------------------  GET THE BOOK ID TO UPDATE  --------------------//
            Console.Write("Enter the Book ID to update: ");
            string idInput = Console.ReadLine();
            Console.WriteLine("");
            //--------------------  VALIDATE BOOK  --------------------//
            if (!int.TryParse(idInput, out int bookId))
            {
                Console.WriteLine("Invalid Book ID.");
                return;
            }

            //--------------------  GET NEW DETAILS FROM THE USER  --------------------//
            Console.Write("New Title: ");
            string title = Console.ReadLine();
            //--------------------  VALIDATE TITLE  --------------------//
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Title cannot be empty.");
                return;
            }

            Console.Write("New Author First Name: ");
            string authorFirstName = Console.ReadLine();
            //--------------------  VALIDATE AUTHOR FIRST NAME  --------------------//
            if (string.IsNullOrWhiteSpace(authorFirstName))
            {
                Console.WriteLine("Author cannot be empty.");
                return;
            }

            Console.Write("New Author Last Name: ");
            string authorLastName = Console.ReadLine();
            //--------------------  VALIDATE AUTHOR LAST NAME  --------------------//
            if (string.IsNullOrWhiteSpace(authorLastName))
            {
                Console.WriteLine("Author cannot be empty.");
                return;
            }

            Console.Write("New Publication Year: ");
            string yearInput = Console.ReadLine();
            int publicationYear = 0;
            if (!string.IsNullOrWhiteSpace(yearInput))
            {
                //--------------------  VALIDATE YEAR INPUT  --------------------//
                if (int.TryParse(yearInput, out int year))
                {
                    publicationYear = year;
                }
                else
                {
                    Console.WriteLine("Invalid year. Please enter a valid integer.");
                    return;
                }
            }

            Console.Write("New Genre: ");
            //--------------------  GET NEW GENRE (OPTIONAL)  --------------------//
            string genre = Console.ReadLine();

            //--------------------  UPDATE BOOK OBJECT WITH NEW DATA  --------------------//
            Book updatedBook = new Book(title, authorFirstName, authorLastName, publicationYear, genre);
            library.UpdateBook(bookId, updatedBook);
        }

        //--------------------  FUNCTION TO DELETE A BOOK  --------------------//
        static void DeleteBook(Library library)
        {
            Console.WriteLine("--- Delete a Book ---");
            Console.WriteLine("");
            //--------------------  GET THE BOOK ID TO DELETE  --------------------//
            Console.Write("Enter the Book ID to delete: ");
            string idInput = Console.ReadLine();

            //--------------------  VALIDATE BOOK ID  --------------------//
            if (!int.TryParse(idInput, out int bookId))
            {
                Console.WriteLine("Invalid Book ID.");
                return;
            }

            //--------------------  DELETE THE BOOK FROM THE LIBRARY  --------------------//
            library.DeleteBook(bookId);
        }

        //--------------------  FUNCTION TO SEARCH FOR BOOKS BY TITLE  --------------------//
        static void SearchBooks(Library library)
        {
            Console.WriteLine("--- Search for a Book by Title ---");
            Console.WriteLine("");

            //--------------------  GET THE TITLE TO SEARCH FOR  --------------------//
            Console.Write("Enter the title to search for: ");
            string title = Console.ReadLine();

            //--------------------  VALIDATE TITLE  --------------------//
            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Title cannot be empty.");
                return;
            }

            //--------------------  SEARCH FOR BOOKS BY TITLE AND DISPLAY THE RESULTS  --------------------//
            library.SearchBooksByTitle(title);
        }
    }
}