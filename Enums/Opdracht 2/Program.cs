using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.Start();
        }

        void Start()
        {
            Persoon[] personen = new Persoon[3];

            for (int i = 0; i < personen.Length; i++)
            {
                personen[i] = LeesPersoon();
            }

            foreach (Persoon persoon in personen)
            {
                PrintPersoon(persoon);
            }

            VierVerjaardag(ref personen[0]);

            PrintPersoon(personen[0]);

            Console.ReadKey();
        }

        void VierVerjaardag(ref Persoon persoon)
        {
            persoon.Leeftijd++;
        }

        Persoon LeesPersoon()
        {
            Persoon persoon;
            persoon.Voornaam = LeesString("Geef de voornaam: ");
            persoon.Achternaam = LeesString("Geef de achternaam: ");
            persoon.Leeftijd = LeesInt("Geef de leeftijd: ");
            persoon.Woonplaats = LeesString("Geef de woonplaats: ");
            persoon.Geslacht = LeesGeslacht();

            return persoon;
        }

        void PrintPersoon(Persoon persoon)
        {
            Console.Write($"{persoon.Voornaam} {persoon.Achternaam} (");
            PrintGeslacht(persoon.Geslacht);
            Console.WriteLine(")");
            Console.WriteLine($"{persoon.Leeftijd} jaar, {persoon.Woonplaats}");
        }

        GeslachtType LeesGeslacht()
        {
            string geslacht = LeesString("Geef het geslacht: ").ToLower();

            if (geslacht == "man")
            {
                return GeslachtType.Man;
            } else if (geslacht == "vrouw")
            {
                return GeslachtType.Vrouw;
            } else
            {
                Console.WriteLine($"{geslacht} is geen geldig geslacht.");

                return LeesGeslacht();
            }
        }

        void PrintGeslacht(GeslachtType geslacht)
        {
            switch (geslacht)
            {
                case GeslachtType.Man:
                    Console.Write("m");
                    break;
                case GeslachtType.Vrouw:
                    Console.Write("v");
                    break;
            }
        }

        int LeesInt(string vraag)
        {
            Console.Write(vraag);

            return int.Parse(Console.ReadLine());
        }

        int LeesInt(string vraag, int min, int max)
        {
            int getal = LeesInt(vraag);

            if (getal >= min && getal <= max)
            {
                return getal;
            }
            else
            {
                Console.WriteLine($"Number is not in the range: {min}..{max}.");

                return LeesInt(vraag, min, max);
            }
        }

        string LeesString(string vraag)
        {
            Console.Write(vraag);

            return Console.ReadLine();
        }
    }
}
