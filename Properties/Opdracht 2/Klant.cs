using System;

namespace Opdracht_2
{
    public class Klant
    {
        private string naam;
        private DateTime geboorteDatum;

        public string Naam {
            get { return naam; }
            set {
                if (value.Length > 0) naam = value;
                else throw new Exception("Invalid name");
            }
        }
        public DateTime InschrijfDatum { get; }

        public DateTime GeboorteDatum {
            get { return geboorteDatum; }
            set {
                if (value < InschrijfDatum) geboorteDatum = value;
                else throw new Exception("Invalid date of birth");
            }
        }
        public int Leeftijd
        {
            get
            {
                return DateTime.Today.Year - GeboorteDatum.Year;
            }
        }
        public bool RechtOpKorting
        {
            get
            {
                return (DateTime.Today - InschrijfDatum).Days > 365;
            }
        }

        public Klant(string naam, DateTime inschrijfDatum, DateTime geboorteDatum)
        {
            Naam = naam;
            InschrijfDatum = inschrijfDatum;
            GeboorteDatum = geboorteDatum;
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Naam);
            Console.ResetColor();
            Console.WriteLine("date of birth: {0}", GeboorteDatum);
            Console.WriteLine("age: {0}", Leeftijd);
            Console.WriteLine("date of registration: {0}", InschrijfDatum);
            Console.WriteLine("discount: {0}", RechtOpKorting);
        }
    }
}
