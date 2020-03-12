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

            Console.WriteLine();
            Console.WriteLine("Customer #2");
            Console.WriteLine(customerDAO.GetById(2));
            Console.WriteLine();

            BookDAO bookDAO = new BookDAO();

            foreach(Book b in bookDAO.GetAll())
            {
                Console.WriteLine(b);
            }

            Console.WriteLine();
            Console.WriteLine("Book #3");
            Console.WriteLine(bookDAO.GetById(3));
            Console.WriteLine();

            ReservationDAO reservationDAO = new ReservationDAO();

            foreach(Reservation r in reservationDAO.GetAll())
            {
                Console.WriteLine(r);
            }

            Console.WriteLine();

            foreach(Book b in bookDAO.GetAll())
            {
                Console.WriteLine("Reservations for book: {0}", b);

                foreach (Customer c in reservationDAO.GetAllForBook(b))
                {
                    Console.WriteLine(c);
                }

                Console.WriteLine();
            }

            foreach(Customer c in customerDAO.GetAll())
            {
                Console.WriteLine("Reservations for customer: {0}", c);

                foreach(Book b in reservationDAO.GetAllForCustomer(c))
                {
                    Console.WriteLine(b);
                }

                Console.WriteLine();
            }
        }
    }
}
