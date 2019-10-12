using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double getal1 = double.Parse(textGetal1.Text);
            double getal2 = double.Parse(textGetal2.Text);
            double uitkomst = getal1 + getal2;

            lblUitkomst.Text = uitkomst.ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            double getal1 = double.Parse(textGetal1.Text);
            double getal2 = double.Parse(textGetal2.Text);
            double uitkomst = getal1 - getal2;

            lblUitkomst.Text = uitkomst.ToString();
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            double getal1 = double.Parse(textGetal1.Text);
            double getal2 = double.Parse(textGetal2.Text);
            double uitkomst = getal1 * getal2;

            lblUitkomst.Text = uitkomst.ToString();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            double getal1 = double.Parse(textGetal1.Text);
            double getal2 = double.Parse(textGetal2.Text);
            double uitkomst = getal1 / getal2;

            lblUitkomst.Text = uitkomst.ToString();
        }
    }
}
