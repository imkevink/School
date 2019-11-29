using System;

namespace Opdracht_3
{
    class YahtzeeGame
    {
        Dobbelsteen[] dobbelstenen;

        public void Init()
        {
            dobbelstenen = new Dobbelsteen[5];
            
            for (int i = 0; i < dobbelstenen.Length; i++)
            {
                dobbelstenen[i] = new Dobbelsteen();
            }
        }

        public void Gooi()
        {
            foreach (Dobbelsteen dobbelsteen in dobbelstenen)
            {
                dobbelsteen.Gooi();
            }
        }

        public void ToonWorp()
        {
            foreach (Dobbelsteen dobbelsteen in dobbelstenen)
            {
                dobbelsteen.ToonWaarde();
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        public bool Yahtzee()
        {
            int waarde = dobbelstenen[0].waarde;

            for (int i = 1; i < dobbelstenen.Length; i++)
            {
                if (dobbelstenen[i].waarde != waarde)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
