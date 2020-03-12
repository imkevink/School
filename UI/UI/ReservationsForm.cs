using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Logic;

namespace UI
{
    public partial class ReservationsForm : Form
    {
        private ReservationService reservationService = new ReservationService();

        public ReservationsForm()
        {
            InitializeComponent();
            DisplayReservations();
        }

        private void DisplayReservations()
        {
            List<Reservation> reservations = reservationService.GetAll();

            foreach (Reservation reservation in reservations)
            {
                ListViewItem li = new ListViewItem(reservation.Id.ToString());

                li.SubItems.Add(reservation.Customer.FullName);
                li.SubItems.Add(reservation.Book.ToString());

                lvReservations.Items.Add(li);
            }
        }
    }
}
