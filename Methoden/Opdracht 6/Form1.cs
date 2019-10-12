using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRef_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(textGetal.Text);

            KwadraatByReference(ref getal);

            lblUitkomst.Text = getal.ToString();
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(textGetal.Text);

            KwadraatByReferenceOut(getal, out int kwadraat);

            lblUitkomst.Text = kwadraat.ToString();
        }

        private void BtnValue_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(textGetal.Text);
            int kwadraat = KwadraatByValue(getal);

            lblUitkomst.Text = kwadraat.ToString();
        }

        void KwadraatByReference(ref int getal)
        {
            getal *= getal;
        }

        void KwadraatByReferenceOut(int getal, out int kwadraat)
        {
            kwadraat = getal * getal;
        }

        int KwadraatByValue(int getal)
        {
            return getal * getal;
        }
    }
}
