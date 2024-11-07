using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Library_Management_System
{
    //--------------------  DATABASE OPERATIONS  --------------------//
    public class DatabaseHandler
    {
        //--------------------  CONNECTION STRING TO THE MYSQL DATABASE  --------------------//
        private string connectionString;

        //--------------------  CONSTRUCTOR TO INITIALISE THE DATABASEHANDLER TO THE CONNECTION STRING  --------------------//
        public DatabaseHandler(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //--------------------  ADD A NEW BOOK TO THE DATABASE  --------------------//
        public void AddBook(Book book)
        {
            string query = "INSERT INTO Books (Title, AuthorFirstName, AuthorLastName, PublicationYear, Genre) VALUES (@Title, @AuthorFirstName, @AuthorLastName, @PublicationYear, @Genre)";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    //--------------------  MAP BOOK PROPERTIES TO SQL PARAMETERS  --------------------//
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@AuthorFirstName", book.AuthorFirstName);
                    cmd.Parameters.AddWithValue("@AuthorLastName", book.AuthorLastName);
                    cmd.Parameters.AddWithValue("@PublicationYear", book.PublicationYear);
                    cmd.Parameters.AddWithValue("@Genre", book.Genre);

                    //--------------------  OPEN DATABASE CONNECTION  --------------------//
                    conn.Open();
                    //--------------------  EXECUTE THE QUERY  --------------------//
                    cmd.ExecuteNonQuery(); 
                }
                Console.WriteLine("");
                Console.WriteLine("Book added successfully...  Please Wait...");
                Thread.Sleep(5000);
                Console.Clear();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            /////////////////////////////////////////////////////////////    INSERT HERE    /////////////////////////////////////////////////////////////

        }
    }
}
