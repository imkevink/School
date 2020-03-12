using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class CustomerDAO
    {
        private SqlConnection dbConnection;

        public CustomerDAO()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["DBConnectionString"]
                .ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();

            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Customer customer = ReadCustomer(reader);

                customers.Add(customer);
            }

            reader.Close();
            dbConnection.Close();

            return customers;
        }

        public Customer GetById(int id)
        {
            dbConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE Id = @Id", dbConnection);

            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;

            if (reader.Read())
                customer = ReadCustomer(reader);

            reader.Close();
            dbConnection.Close();

            return customer;
        }

        private Customer ReadCustomer(SqlDataReader reader)
        {
            int id = (int)reader["id"];
            string firstName = (string)reader["FirstName"];
            string lastName = (string)reader["LastName"];
            string emailAddress = (string)reader["EmailAddresss"];

            return new Customer(id, firstName, lastName, emailAddress);
        }
    }
}
