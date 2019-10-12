using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnOmrekenen_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textGraden.Text);

            if (celToKel.Checked) lblUitkomst.Text = CelciusToKelvin(input).ToString();
            else if (celToFahr.Checked) lblUitkomst.Text = CelciusToFahrenheid(input).ToString();
            else lblUitkomst.Text = FahrenheidToCelcius(input).ToString();
        }

        private double CelciusToKelvin(double c)
        {
            return c + 273;
        }

        private double CelciusToFahrenheid(double c)
        {
            return c * (9d / 5) + 32;
        }

        private double FahrenheidToCelcius(double f)
        {
            return (f - 32) * (5d / 9);
        }
    }
}
