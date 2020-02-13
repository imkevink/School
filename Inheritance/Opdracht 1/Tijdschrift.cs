using System;

namespace Opdracht_1
{
    public class Tijdschrift : Boek
    {
        public string uitgifte;

        public Tijdschrift(string titel, string uitgifte, double prijs)
            : base(titel, "", prijs)
        {
            this.uitgifte = uitgifte;
        }

        public override void Print()
        {
            Console.WriteLine("[Tijdscript] {0} - release day: {1}, {2}", this.titel, this.uitgifte, this.prijs.ToString("0.00"));
        }
    }
}
