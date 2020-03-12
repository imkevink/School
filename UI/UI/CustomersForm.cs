using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Logic;

namespace UI
{
    public partial class CustomersForm : Form
    {
        private CustomerService customerService = new CustomerService();
        private ReservationService reservationService = new ReservationService();

        public CustomersForm()
        {
            InitializeComponent();
            DisplayCustomers();
        }

        private void DisplayCustomers()
        {
            List<Customer> customers = customerService.GetAll();

            foreach (Customer customer in customers)
            {
                cmbCustomers.Items.Add(customer);
            }

            cmbCustomers.SelectedIndex = 0;
        }

        private void CmbCustomers_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Customer customer = (Customer)cmbCustomers.SelectedItem;
            List<Book> reservations = reservationService.GetAllForCustomer(customer);

            lstReservations.Items.Clear();

            foreach (Book book in reservations)
                lstReservations.Items.Add(book);

            if (reservations.Count > 0)
                lstReservations.SelectedIndex = 0;

            lstReservations.Focus();
        }
    }
}