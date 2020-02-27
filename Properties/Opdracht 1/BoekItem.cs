namespace Opdracht_1
{
    public abstract class BoekItem
    {
        public string Titel { get; set; }
        public double Prijs { get; set; }
        public int Count { get; set; }
        public double TotaalPrijs
        {
            get
            {
                return Count * Prijs;
            }
        }

        public BoekItem(string titel, double prijs, int aantal)
        {
            Titel = titel;
            Prijs = prijs;
            Count = aantal;
        }

        public abstract void Print();
    }
}
