using System;
using System.Collections.Generic;

namespace Opdracht_2
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
            try
            {
                Klant messi = new Klant("Lionel Messi", DateTime.Now, DateTime.Parse("24/06/1987"));
                Klant piet = new Klant("Piet Paulusma", DateTime.Parse("20/02/2017"), DateTime.Parse("15/12/1956"));

                messi.Print();
                piet.Print();

                Kaartje rapsody = new Kaartje("Bohemian Rapsody", 1, DateTime.Parse("23/02/2019 21:30:00"), 10.50, 6);
                Kaartje prodigy = new Kaartje("The Prodigy", 4, DateTime.Parse("23/02/2019 22:00:00"), 10.50, 16);
                Kaartje book = new Kaartje("Green Book", 5, DateTime.Parse("25/02/2019 19:00:00"), 10.50, 12);

                Reservering r_messi = new Reservering(messi);

                r_messi.Kaartjes.Add(rapsody);
                r_messi.Kaartjes.Add(prodigy);
                r_messi.Kaartjes.Add(book);
                r_messi.Print();

                Reservering r_piet = new Reservering(piet);

                r_piet.Kaartjes.Add(rapsody);
                r_piet.Kaartjes.Add(prodigy);
                r_piet.Kaartjes.Add(book);
                r_piet.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred: {0}", e.Message);
            }
        }
    }
}
