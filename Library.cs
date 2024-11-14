using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System;
using Mysqlx.Crud;
using static System.Reflection.Metadata.BlobBuilder;
namespace Library_Management_System
{
    //--------------------  REPRESENTS A LIBRARY THAT INTERACTS WITH THE DATABASE TO MANAGE BOOKS  --------------------//
    public class Library
    {
        //--------------------  DATABASE HANDLER TO INTERACT WITH THE DATABASE  --------------------//
        private readonly DatabaseHandler dbHandler;

        //--------------------  CONSTRUCTOR TO INITIALISE THE LIBRARY CLASS WITH A DATABASEHANDLER  --------------------//
        public Library(DatabaseHandler dbHandler)
        {
            this.dbHandler = dbHandler;
        }
//
//------------------------------------------------------------------------------------------------------------------------------------------------//
//
        //--------------------  ADD A NEW BOOK TO THE LIBRARY  --------------------//
        public void AddBook(Book book)
        {
            //--------------------  CALL THE ADDBOOK METHOD FROM DATABASEHANDLER  --------------------//
            dbHandler.AddBook(book); 
        }
//
//------------------------------------------------------------------------------------------------------------------------------------------------//
//
        //--------------------  DISPLAY ALL BOOKS CURRENTLY IN THE LIBRARY  --------------------//
        public void ViewAllBooks()
        {
            //--------------------  RETRIEVE THE LIST OF ALL BOOKS FROM THE DATABASEHANDLER  --------------------//
            List<Book> books = dbHandler.GetAllBooks();

            //--------------------  IF NO BOOKS ARE FOUND, DISPLAY A MESSAGE AND RETURN  --------------------//
            if (books.Count == 0)
            {
                Console.WriteLine("No books found.");
                return;
            }

            //--------------------  DISPLAY THE LIST OF BOOKS  --------------------//
            Console.WriteLine("List of Books:");
            Console.WriteLine("{0,-5} {1,-40} {2,-15} {3,-15} {4,-6} {5,-20}", "ID", "Title", "AuthorFirstName", "AuthorLastName", "Year", "Genre");
            Console.WriteLine(new string('-', 100));

            //--------------------  ITERATE THROUGH EACH BOOK IN THE LIST  --------------------//
            foreach (var book in books)
            {
                //--------------------  PRINT BOOK DETAILS IN A TABULAR FORMAT  --------------------//
                Console.WriteLine("{0,-5} {1,-40} {2,-15} {3,-15} {4,-6} {5,-20}", book.BookID, book.Title, book.AuthorFirstName, book.AuthorLastName, book.PublicationYear, book.Genre);
            }
        }
//
//------------------------------------------------------------------------------------------------------------------------------------------------//
//
        //--------------------  UPDATE AN EXISTING BOOK'S DETAILS IN THE LIBRARY  --------------------//
        public void UpdateBook(int bookId, Book updatedBook)
        {
            //--------------------  CALL THE UPDATEBOOK METHOD FROM DATABASEHANDLER  --------------------//
            dbHandler.UpdateBook(bookId, updatedBook);
        }
//
//------------------------------------------------------------------------------------------------------------------------------------------------//
//
        //--------------------  DELETE A BOOK FROM THE LIBRARY BY ITS ID  --------------------//
        public void DeleteBook(int bookId)
        {
            //--------------------  CALL THE DELETEBOOK METHOD FROM DATABASEHANDLER  --------------------//
            dbHandler.DeleteBook(bookId);
        }
        /////////////////////////////////////////////////////////////    INSERT HERE    /////////////////////////////////////////////////////////////
    }
}