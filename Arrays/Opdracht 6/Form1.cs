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
        int[] tabel = new int[20];

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();

            for (int i = 0; i < tabel.Length; i++)
            {
                int getal = rnd.Next(0, 500);

                tabel[i] = getal;
                labelVooraf.Text += $"Element {i.ToString("00")} = {getal}\n";
            }
        }

        private void ButtonVergelijk_Click(object sender, EventArgs e)
        {
            int vergelijkingsGetal = int.Parse(textBoxVergelijkingsgetal.Text);

            for (int i = 0; i < tabel.Length; i++)
            {
                int getal = tabel[i];

                if (getal >= vergelijkingsGetal) getal += 10;
                else getal -= 5;

                labelAchteraf.Text += $"Element {i.ToString("00")} = {getal}\n";
            }

            buttonVergelijk.Enabled = false;
        }
    }
}
