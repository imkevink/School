using System;

namespace Opdracht_1
{
    public class Boek : BoekItem
    {
        public string auteur;

        public Boek(string titel, string auteur, double prijs)
            : base(titel, prijs)
        {
            this.auteur = auteur;
        }

        public override void Print()
        {
            Console.WriteLine("[Boek] '{0}' by {1}, {2}", this.titel, this.auteur, this.prijs.ToString("0.00"));
        }
    }
}
