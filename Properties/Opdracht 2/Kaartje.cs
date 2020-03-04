using System;

namespace Opdracht_2
{
    public class Kaartje
    {
        private string filmNaam;
        private int zaal;
        private DateTime aanvangstTijd;
        private int minimumLeeftijd;

        public string FilmNaam
        {
            get { return filmNaam; }
            set {
                if (value.Length > 0) filmNaam = value;
                else throw new ArgumentException("Invalid film name");
            }
        }

        public int Zaal
        {
            get { return zaal; }
            set {
                if (value >= 1 && value <= 5) zaal = value;
                else throw new ArgumentException(string.Format("Invalid cinema room ({0})", value));
            }
        }

        public DateTime AanvangstTijd
        {
            get { return aanvangstTijd; }
            set {
                if (value.Minute == 0 || value.Minute == 30 || value.Minute == 60) aanvangstTijd = value;
                else throw new ArgumentException(string.Format("Invalid start time ({0})", value));
            }
        }

        public double Prijs { get; set; }

        public int MinimumLeeftijd
        {
            get { return minimumLeeftijd; }
            set {
                if (value == 0 || value == 6 || value == 9 || value == 12 || value == 16) minimumLeeftijd = value;
                else throw new ArgumentException(string.Format("Invalid minimum age ({0})", value));
            }
        }

        public bool Korting
        {
            get
            {
                return AanvangstTijd.DayOfWeek == DayOfWeek.Monday || aanvangstTijd.DayOfWeek == DayOfWeek.Tuesday;
            }
        }

        public Kaartje(string filmNaam, int zaal, DateTime aanvangstTijd, double prijs, int minimumLeeftijd)
        {
            FilmNaam = filmNaam;
            Zaal = zaal;
            AanvangstTijd = aanvangstTijd;
            Prijs = prijs;
            MinimumLeeftijd = minimumLeeftijd;
        }

        public void Print()
        {
            Console.WriteLine("'{0}', start time: {1}, price: {2}, room: {3} ({4}+)", FilmNaam, AanvangstTijd, Prijs, Zaal, MinimumLeeftijd);
        }
    }
}
