using System;
using System.Collections.Generic;
using System.IO;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.Start();

            Console.ReadKey();
        }

        void Start()
        {
            List<Plaat> platen;

            try
            {
                platen = LeesPlaten("top2000-2019.csv");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Kon het bestand met platen niet lezen: {0}", ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Er is een fout met het lezen van de platen: {0}", ex.Message);

                return;
            }

            if (platen.Count == 0) return;

            ToonPlaten(platen);

            List<string> dubbele_artiesten = DubbeleArtiesten(platen);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Dubbele artiesten");
            Console.ResetColor();

            foreach (string artiest in dubbele_artiesten)
            {
                Console.WriteLine(artiest);
            }

            Dictionary<string, List<Plaat>> dubbele_titels = DubbeleTitels(platen);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Veel voorkomende titels");
            Console.ResetColor();

            ToonDubbeleTitels(dubbele_titels);
        }

        List<Plaat> LeesPlaten(string bestand)
        {
            List<Plaat> platen = new List<Plaat>();
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(bestand);

                while (!reader.EndOfStream)
                {
                    string regel = reader.ReadLine();
                    string[] velden = regel.Split(';');

                    platen.Add(new Plaat
                    {
                        ranking = int.Parse(velden[0]),
                        titel = velden[1],
                        artiest = velden[2],
                        jaar = int.Parse(velden[3]),
                    });
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return platen;
        }

        void ToonPlaten(List<Plaat> platen)
        {
            foreach (Plaat plaat in platen)
            {
                Console.WriteLine("{0}. {1} - {2}", plaat.ranking, plaat.artiest, plaat.titel);
            }
        }

        List<string> DubbeleArtiesten(List<Plaat> platen)
        {
            List<string> resultaat = new List<string>();

            for (int i = 0; i < platen.Count; i++)
            {
                if (i > 0 && platen[i].artiest == platen[i - 1].artiest && !resultaat.Contains(platen[i].artiest))
                    resultaat.Add(platen[i].artiest);
            }

            return resultaat;
        }

        Dictionary<string, List<Plaat>> DubbeleTitels(List<Plaat> platen)
        {
            Dictionary<string, List<Plaat>> resultaat = new Dictionary<string, List<Plaat>>();

            foreach (Plaat plaat in platen)
            {
                if (!resultaat.ContainsKey(plaat.titel))
                    resultaat.Add(plaat.titel, new List<Plaat>());

                resultaat[plaat.titel].Add(plaat);
            }

            return resultaat;
        }

        void ToonDubbeleTitels(Dictionary<string, List<Plaat>> titel_platen)
        {
            foreach (KeyValuePair<string, List<Plaat>> entry in titel_platen)
            {
                if (entry.Value.Count >= 3)
                {
                    Console.WriteLine("{0} ({1}x)", entry.Key, entry.Value.Count);

                    foreach (Plaat plaat in entry.Value)
                    {
                        Console.WriteLine("  {0,4}. {1}", plaat.ranking, plaat.artiest);
                    }
                }
            }
        }
    }
}
