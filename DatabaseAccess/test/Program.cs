using System;
using DAL;
using Model;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Start();
            Console.ReadKey();
        }

        void Start()
        {
            CustomerDAO customerDAO = new CustomerDAO();

            foreach (Customer c in customerDAO.GetAll())
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Customer #2");
            Console.WriteLine(customerDAO.GetById(2));

            BookDAO bookDAO = new BookDAO();

            foreach(Book b in bookDAO.GetAll())
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("Book #3");
            Console.WriteLine(bookDAO.GetById(3));

            ReservationDAO reservationDAO = new ReservationDAO();

            foreach(Reservation r in reservationDAO.GetAll())
            {
                Console.WriteLine(r);
            }
        }
    }
}
