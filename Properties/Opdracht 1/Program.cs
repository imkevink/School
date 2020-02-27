using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.Start();

            Console.ReadKey();
        }

        void Start()
        {
            BoekHandel handel = new BoekHandel();

            handel.VoegToe(new Boek("Dracula", "Bram Stoker", 15.00, 5));
            handel.VoegToe(new Boek("Joe speedboot", "Tommy Wieringa", 12.50, 5));
            handel.VoegToe(new Tijdschrift("Time", "Friday", 3.90, 10));
            handel.VoegToe(new Tijdschrift("Donald Duck", "Thursday", 2.50, 8));
            handel.VoegToe(new Boek("The hobbit", "J.R.R. Tolkien", 12.50, 4));

            handel.PrintVoorraad();
        }
    }
}
