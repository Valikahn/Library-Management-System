using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Library_Management_System
{
    //--------------------  REPRESENTS A BOOK IN THE LIBRARY MANAGEMENT SYSTEM  --------------------//
    public class Book
    {
        //--------------------  UNIQUE IDENTIFIER FOR THE BOOK  --------------------//
        public int BookID { get; set; }

        //--------------------  TITLE OF THE BOOK  --------------------//
        public string Title { get; set; }

        //--------------------  AUTHOR OF THE BOOK FIRSTNAME  --------------------//
        public string AuthorFirstName { get; set; }

        //--------------------  AUTHOR OF THE BOOK LASTNAME  --------------------//
        public string AuthorLastName { get; set; }

        //--------------------  YEAR THE BOOK WAS PUBLISHED  --------------------//
        public int PublicationYear { get; set; }

        //--------------------  GENRE OR CATEGORY OF THE BOOK  --------------------//
        public string Genre { get; set; }

        //--------------------  DEFAULT CONSTRUCTOR (PARAMETERLESS)  --------------------//
        public Book() { }

        //--------------------  PARAMETERISED CONSTRUCTOR TO INITIALISE A BOOK WITH SPECIFIC DETAILS  --------------------//
        public Book(string title, string authorFirstName, string authorLastName, int publicationYear, string genre)
        {
            //--------------------  ASSIGN THE TITLE OF THE BOOK  --------------------//
            Title = title;
            //--------------------  ASSIGN THE AUTHOR OF THE BOOK FIRSTNAME  --------------------//
            AuthorFirstName = authorFirstName;
            //--------------------  ASSIGN THE AUTHOR OF THE BOOK LASTNAME  --------------------//
            AuthorLastName = authorLastName;
            //--------------------  ASSIGN THE PUBLICATION YEAR (NULLABLE)  --------------------//
            PublicationYear = publicationYear;
            //--------------------  ASSIGN THE GENRE OF THE BOOK  --------------------//
            Genre = genre;
        }
    }
}