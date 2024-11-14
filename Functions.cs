using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library_Management_System
{
    public class Functions
    {
//
//------------------------------------------------------------------------------------------------------------------------------------------------//
//
        //--------------------  FUNCTION TO ADD A NEW BOOK  --------------------//
        public static void AddBook(Library library)
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
//
//------------------------------------------------------------------------------------------------------------------------------------------------//
//
        //--------------------  FUNCTION TO DISPLAY ALL BOOKS IN DATABASE  --------------------//
        public static void GetAllBooks(Library library)
        {
            Console.WriteLine("--- Display all Books ---");
            Console.WriteLine("");

            //--------------------  DISPLAY ALL BOOKS IN DATABASE  --------------------//
            library.ViewAllBooks();
        }
//
//------------------------------------------------------------------------------------------------------------------------------------------------//
//
        //--------------------  FUNCTION TO UPDATE BOOK DETAILS  --------------------//
        public static void UpdateBook(Library library)
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
//
//------------------------------------------------------------------------------------------------------------------------------------------------//
//
        //--------------------  FUNCTION TO DELETE A BOOK  --------------------//
        public static void DeleteBook(Library library)
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

        /////////////////////////////////////////////////////////////    INSERT HERE    /////////////////////////////////////////////////////////////
    }
}
