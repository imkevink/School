using System.Collections.Generic;
using DAL;
using Model;

namespace Logic
{
    public class CustomerService
    {
        private CustomerDAO customerDAO = new CustomerDAO();

        public List<Customer> GetAll()
        {
            return customerDAO.GetAll();
        }
    }
}
