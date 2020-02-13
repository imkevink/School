using System;

namespace Opdracht_1
{
    public class Boek
    {
        public string titel;
        public string auteur;
        public double prijs;

        public Boek(string titel, string auteur, double prijs)
        {
            this.titel = titel;
            this.auteur = auteur;
            this.prijs = prijs;
        }

        public virtual void Print()
        {
            Console.WriteLine("[Boek] '{0}' by {1}, {2}", this.titel, this.auteur, this.prijs.ToString("0.00"));
        }
    }
}
