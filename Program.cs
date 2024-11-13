using System;
using System.Collections.Generic;
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
            string connectionString = "server=10.11.22.43;port=3306;database=LibraryDB;user=phpMyAdmin;password=Enzc7Sqs8vSviiPx";

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
                //Console.WriteLine("4. [D] DELETE A BOOK");
                //Console.WriteLine("5. [S] SEARCH FOR A BOOK BY TITLE");
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
                        Functions.AddBook(library);
                        break;
                    //--------------------  USER CHOOSES TO [R] VIEW ALL BOOKS CURRENTLY IN THE DATABASE WITH THIS SWITCHCASE FUNCTION  --------------------//
                    case "2" or "r" or "R":
                        Console.Clear();
                        Functions.GetAllBooks(library);
                        break;
                    //--------------------  USER CHOOSES TO [U] UPDATE A BOOK IN THE DATABASE WITH THIS SWITCHCASE FUNCTION  --------------------//
                    case "3" or "u" or "U":
                        Console.Clear();
                        Functions.UpdateBook(library);
                        break;
                    //--------------------  USER CHOOSES TO [D] DELETE A BOOK FROM THE DATABASE WITH THIS SWITCHCASE FUNCTION  --------------------//

                    case "4":
                        Console.Clear();
                        break;
                    //--------------------  USER CHOOSES TO [S] SEARCH FOR A BOOK CURRENTLY IN THE DATABASE WITH THIS SWITCHCASE FUNCTION  --------------------//
                    case "5":
                        Console.Clear();
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
    }
}