using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System;
using Mysqlx.Crud;
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

        //--------------------  ADD A NEW BOOK TO THE LIBRARY  --------------------//
        public void AddBook(Book book)
        {
            //--------------------  CALL THE ADDBOOK METHOD FROM DATABASEHANDLER  --------------------//
            dbHandler.AddBook(book); 
        }

        /////////////////////////////////////////////////////////////    INSERT HERE    /////////////////////////////////////////////////////////////

    }
}