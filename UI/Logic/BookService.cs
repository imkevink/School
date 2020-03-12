using System.Collections.Generic;
using DAL;
using Model;

namespace Logic
{
    public class BookService
    {
        private BookDAO bookDAO = new BookDAO();

        public List<Book> GetAll()
        {
            return bookDAO.GetAll();
        }
    }
}
