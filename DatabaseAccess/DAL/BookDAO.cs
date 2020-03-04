using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class BookDAO
    {
        private SqlConnection dbConnection;

        public BookDAO()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["DBConnectionString"]
                .ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();

            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Books", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Book book = ReadBook(reader);

                books.Add(book);
            }

            reader.Close();
            dbConnection.Close();

            return books;
        }

        public Book GetById(int id)
        {
            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE Id = @Id", dbConnection);

            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            Book book = null;

            if (reader.Read())
                book = ReadBook(reader);

            reader.Close();
            dbConnection.Close();

            return book;
        }

        private Book ReadBook(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string title = (string)reader["Title"];
            string author = (string)reader["Author"];

            return new Book(id, title, author);
        }
    }
}
