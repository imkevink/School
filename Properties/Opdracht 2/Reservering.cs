using System;
using System.Collections.Generic;

namespace Opdracht_2
{
    public class Reservering
    {
        const double KORTING_PER_KAARJTE = 0.95;
        const double KORTING_VASTE_KLANT = 0.90;

        public Klant Klant { get; set; }
        public List<Kaartje> Kaartjes { get; }

        public double TotaalPrijs
        {
            get
            {
                double totaal = 0;

                foreach(Kaartje kaartje in Kaartjes)
                {
                    if (Klant.Leeftijd < kaartje.MinimumLeeftijd)
                        throw new Exception(string.Format("{0} is not old enought to see {1}", Klant.Naam, kaartje.FilmNaam));

                    if (kaartje.Korting)
                        totaal += kaartje.Prijs * KORTING_PER_KAARJTE;
                    else
                        totaal += kaartje.Prijs;
                }

                if (Klant.RechtOpKorting)
                    return totaal * KORTING_VASTE_KLANT;
                else
                    return totaal;
            }
        }

        public Reservering(Klant klant)
        {
            Klant = klant;
            Kaartjes = new List<Kaartje>();
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tickets for {0}", Klant.Naam);
            Console.ResetColor();

            foreach(Kaartje kaartje in Kaartjes)
            {
                kaartje.Print();
            }

            Console.WriteLine("total price of reservation: {0}", TotaalPrijs);
        }
    }
}
