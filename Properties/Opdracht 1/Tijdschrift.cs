using System;

namespace Opdracht_1
{
    public class Tijdschrift : BoekItem
    {
        public string uitgifte { get; set; }

        public Tijdschrift(string titel, string uitgifte, double prijs, int aantal)
            : base(titel, prijs, aantal)
        {
            this.uitgifte = uitgifte;
        }

        public override void Print()
        {
            Console.WriteLine("[Tijdscript] {0} - release day: {1}, {2} ({3}x)", Titel, this.uitgifte, Prijs.ToString("0.00"), Count);
        }
    }
}
