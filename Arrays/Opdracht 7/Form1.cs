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

        private void ButtonGooien_Click(object sender, EventArgs e)
        {
            int[] dice = new int[6];
            Random rnd = new Random();

            for (int i = 0; i < 6000; i++)
            {
                int value = rnd.Next(1, 7);

                dice[value - 1]++;
            }

            labelWaarde1.Text = $"Waarde 1 is {dice[0]} keer gegooid";
            labelWaarde2.Text = $"Waarde 2 is {dice[1]} keer gegooid";
            labelWaarde3.Text = $"Waarde 3 is {dice[2]} keer gegooid";
            labelWaarde4.Text = $"Waarde 4 is {dice[3]} keer gegooid";
            labelWaarde5.Text = $"Waarde 5 is {dice[4]} keer gegooid";
            labelWaarde6.Text = $"Waarde 6 is {dice[5]} keer gegooid";
        }
    }
}
