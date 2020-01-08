using System;
using System.IO;
using System.Collections.Generic;

namespace Opdracht_1
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
            string naam = LeesString("Wat is uw naam? ");

            Persoon persoon;

            try
            {
                persoon = LeesPersoon(naam, "personen.txt");
            } catch
            {
                Console.WriteLine("Kon personen.txt niet lezen");
                return;
            }

            ToonPersoon(persoon);

            Console.ReadKey();
        }

        Persoon LeesPersoon()
        {
            return new Persoon
            {
                naam = LeesString("Geef de naam: "),
                woonplaats = LeesString("Geef de woonplaats: "),
                leeftijd = LeesInt("Geef de leeftijd: "),
            };
        }

        Persoon LeesPersoon(string naam, string path)
        {
            StreamReader file = null;

            try
            {
                file = new StreamReader(path);
                Dictionary<string, Persoon> personen = new Dictionary<string, Persoon>();

                foreach (string line in file.ReadToEnd().Split('\n'))
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        Persoon persoon = new Persoon
                        {
                            naam = parts[0],
                            woonplaats = parts[2],
                            leeftijd = int.Parse(parts[1]),
                        };

                        personen.Add(persoon.naam, persoon);
                    }
                }

                file.Close();

                if (personen.ContainsKey(naam))
                {
                    return personen[naam];
                }
                else
                {
                    Persoon persoon = LeesPersoon();

                    SchrijfPersoon(persoon, path);

                    return persoon;
                }
            }
            finally
            {
                file.Close();
            }
        }

        void ToonPersoon(Persoon persoon)
        {
            Console.WriteLine("{0}, {1} jaar uit {2}", persoon.naam, persoon.leeftijd, persoon.woonplaats);
        }

        void SchrijfPersoon(Persoon persoon, string path)
        {
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                reader = new StreamReader(path);
                string content = reader.ReadToEnd();

                reader.Close();

                writer = new StreamWriter(path);

                writer.Write(content);
                writer.WriteLine("{0}, {1}, {2}", persoon.naam, persoon.leeftijd, persoon.woonplaats);
            } catch
            {
                Console.WriteLine("Kon het bestand {0} niet vinden", path);
            } finally
            {
                reader.Close();
                writer.Close();
            }
        }

        int LeesInt(string vraag)
        {
            Console.Write(vraag);

            int value;

            while (!int.TryParse(Console.ReadLine(), out value))
                Console.Write(vraag);

            return value;
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
