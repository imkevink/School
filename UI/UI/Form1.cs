using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm form = new CustomersForm();

            form.ShowDialog();
        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksForm form = new BooksForm();

            form.ShowDialog();
        }

        private void ReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationsForm form = new ReservationsForm();

            form.ShowDialog();
        }
    }
}
