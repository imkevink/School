using System.Collections.Generic;
using DAL;
using Model;

namespace Logic
{
    public class ReservationService
    {
        private ReservationDAO reservationDAO = new ReservationDAO();

        public List<Reservation> GetAll()
        {
            return reservationDAO.GetAll();
        }

        public List<Book> GetAllForCustomer(Customer customer)
        {
            return reservationDAO.GetAllForCustomer(customer);
        }

        public List<Customer> GetAllForBook(Book book)
        {
            return reservationDAO.GetAllForBook(book);
        }
    }
}
