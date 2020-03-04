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
                "SELECT Reservations.Id, Reservations.CustomerId, Reservations.BookId,\n" +
                "       Customers.FirstName as CustomerFirstName, Customers.LastName as CustomerLastName, Customers.EmailAddresss as CustomerEmailAddress,\n" +
                "       Books.Title as BookTitle, Books.Author as BookAuthor\n" +
                "FROM Reservations\n" +
                "JOIN Customers ON Reservations.CustomerId = Customers.Id\n" +
                "JOIN Books ON Reservations.BookId = Books.Id",
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
