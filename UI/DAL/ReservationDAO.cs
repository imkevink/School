using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class ReservationDAO
    {
        private SqlConnection dbConnection;

        public ReservationDAO()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["DBConnectionString"]
                .ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Reservation> GetAll()
        {
            List<Reservation> reservations = new List<Reservation>();

            dbConnection.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT Reservations.Id, CustomerId, BookId,\n" +
                "       FirstName as CustomerFirstName, LastName as CustomerLastName, EmailAddresss as CustomerEmailAddress,\n" +
                "       Title as BookTitle, Author as BookAuthor\n" +
                "FROM Reservations\n" +
                "JOIN Customers ON CustomerId = Customers.Id\n" +
                "JOIN Books ON BookId = Books.Id",
                dbConnection
            );
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Reservation reservation = ReadReservation(reader);

                reservations.Add(reservation);
            }

            reader.Close();
            dbConnection.Close();

            return reservations;
        }

        public List<Customer> GetAllForBook(Book book)
        {
            List<Customer> customers = new List<Customer>();

            dbConnection.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT Customers.Id, FirstName as CustomerFirstName, LastName as CustomerLastName, EmailAddresss as CustomerEmailAddress\n" +
                "FROM Reservations\n" +
                "JOIN Customers on CustomerId = Customers.Id\n" +
                "WHERE BookId = @BookId",
                dbConnection
            );

            cmd.Parameters.AddWithValue("@BookId", book.Id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int customerId = (int)reader["Id"];
                string customerFirstName = (string)reader["CustomerFirstName"];
                string customerLastName = (string)reader["CustomerLastName"];
                string customerEmailAddress = (string)reader["CustomerEmailAddress"];

                customers.Add(new Customer(customerId, customerFirstName, customerLastName, customerEmailAddress));
            }

            reader.Close();
            dbConnection.Close();

            return customers;
        }

        public List<Book> GetAllForCustomer(Customer customer)
        {
            List<Book> books = new List<Book>();

            dbConnection.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT Books.Id, Title as BookTitle, Author as BookAuthor\n" +
                "FROM Reservations\n" +
                "JOIN Books ON BookId = Books.Id\n" +
                "WHERE CustomerId = @CustomerId",
                dbConnection
            );

            cmd.Parameters.AddWithValue("@CustomerId", customer.Id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["Id"];
                string title = (string)reader["BookTitle"];
                string author = (string)reader["BookAuthor"];

                books.Add(new Book(id, title, author));
            }

            reader.Close();
            dbConnection.Close();

            return books;
        }

        private Reservation ReadReservation(SqlDataReader reader)
        {
            int id = (int)reader["Id"];
            int customerId = (int)reader["CustomerId"];
            string customerFirstName = (string)reader["CustomerFirstName"];
            string customerLastName = (string)reader["CustomerLastName"];
            string customerEmailAddress = (string)reader["CustomerEmailAddress"];

            Customer customer = new Customer(customerId, customerFirstName, customerLastName, customerEmailAddress);

            int bookId = (int)reader["BookId"];
            string bookTitle = (string)reader["BookTitle"];
            string bookAuthor = (string)reader["BookAuthor"];

            Book book = new Book(bookId, bookTitle, bookAuthor);

            return new Reservation(id, customer, book);
        }
    }
}
