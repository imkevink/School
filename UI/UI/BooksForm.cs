using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Logic;

namespace UI
{
    public partial class BooksForm : Form
    {
        private BookService bookService = new BookService();
        private ReservationService reservationService = new ReservationService();

        public BooksForm()
        {
            InitializeComponent();
            DisplayBooks();
        }

        private void DisplayBooks()
        {
            List<Book> books = bookService.GetAll();

            foreach (Book book in books)
                cmbBooks.Items.Add(book);

            cmbBooks.SelectedIndex = 0;
        }

        private void CmbBooks_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Book book = (Book)cmbBooks.SelectedItem;
            List<Customer> reservations = reservationService.GetAllForBook(book);

            lstReservations.Items.Clear();

            foreach (Customer customer in reservations)
                lstReservations.Items.Add(customer);

            if (reservations.Count > 0)
                lstReservations.SelectedIndex = 0;

            lstReservations.Focus();
        }
    }
}
