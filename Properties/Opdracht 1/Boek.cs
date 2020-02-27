using System;

namespace Opdracht_1
{
    public class Boek : BoekItem
    {
        public string auteur { get; }

        public Boek(string titel, string auteur, double prijs, int aantal)
            : base(titel, prijs, aantal)
        {
            this.auteur = auteur;
        }

        public override void Print()
        {
            Console.WriteLine("[Boek] '{0}' by {1}, {2} ({3}x)", Titel, this.auteur, Prijs.ToString("0.00"), Count);
        }
    }
}
