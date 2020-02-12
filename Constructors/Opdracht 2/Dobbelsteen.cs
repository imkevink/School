using System;

namespace Opdracht_3
{
    class Dobbelsteen
    {
        public int waarde;
        private Random rnd;

        public Dobbelsteen(Random rnd)
        {
            this.rnd = rnd;
        }

        public void Gooi()
        {
            waarde = rnd.Next(1, 7);
        }

        public void ToonWaarde()
        {
            Console.Write($"{waarde}");
        }
    }
}
