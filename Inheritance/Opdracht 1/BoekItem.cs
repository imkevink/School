namespace Opdracht_1
{
    public abstract class BoekItem
    {
        public string titel;
        public double prijs;

        public BoekItem(string titel, double prijs)
        {
            this.titel = titel;
            this.prijs = prijs;
        }

        public abstract void Print();
    }
}
