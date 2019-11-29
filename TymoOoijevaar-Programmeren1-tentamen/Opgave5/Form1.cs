using System;
using System.Windows.Forms;

namespace Opgave5
{
    public partial class Opgave5 : Form
    {
        const double TweedeKlassePrijs = 53.00;
        const double EersteKlassePrijs = 87.46;
        const double RailrunnerPrijs = 2.50;

        public Opgave5()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(txtAantal.Text);
            int railrunner = int.Parse(txtRailrunner.Text);
            double totaal = railrunner * RailrunnerPrijs;

            if (rbtnTweedeKlasse.Checked)
            {
                totaal += aantal * TweedeKlassePrijs;
            } else
            {
                totaal += aantal * EersteKlassePrijs;
            }

            txtPrijs.Text = totaal.ToString("0.00");
        }
    }
}
