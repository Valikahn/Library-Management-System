using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library_Management_System
{
    public class Functions
    {
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
            //--------------------  NULLABLE INTEGER FOR OPTIONAL YEAR  --------------------//
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
            //--------------------  GET GENRE (OPTIONAL)  --------------------//
            string genre = Console.ReadLine();

            //--------------------  CREATE A NEW BOOK OBJECT AND ADD IT TO THE LIBRARY  --------------------//
            Book newBook = new Book(title, authorFirstName, authorLastName, publicationYear, genre);
            library.AddBook(newBook);
        }

        // Function to display all books in Database
        public static void GetAllBooks(Library library)
        {
            Console.WriteLine("--- Display all Books ---");
            Console.WriteLine("");

            // Display all books
            library.ViewAllBooks();
        }

        /////////////////////////////////////////////////////////////    INSERT HERE    /////////////////////////////////////////////////////////////

    }
}
