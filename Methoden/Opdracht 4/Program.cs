using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = Console.ReadLine();

            OnderzoekTekst(tekst, out int aantalPunten, out int aantalKommas, out int aantalPuntKommas);

            Console.WriteLine($"Aantal punten: {aantalPunten}");
            Console.WriteLine($"Aantal kommas: {aantalKommas}");
            Console.WriteLine($"Aantal puntkommas: {aantalPuntKommas}");

            Console.ReadKey();
        }

        static void OnderzoekTekst(string tekst, out int aantalPunten, out int aantalKommas, out int aantalPuntKommas)
        {
            aantalPunten = 0;
            aantalKommas = 0;
            aantalPuntKommas = 0;

            foreach (char letter in tekst)
            {
                switch (letter)
                {
                    case '.':
                        aantalPunten++;
                        break;
                    case ',':
                        aantalKommas++;
                        break;
                    case ';':
                        aantalPuntKommas++;
                        break;
                }
            }
        }
    }
}
