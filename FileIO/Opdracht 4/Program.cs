using System;
using System.IO;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Start();
        }

        const int FIELD_SIZE = 9;

        void Start()
        {
            RegularCandies[,] speelveld;
            try
            {
                speelveld = LeesSpeelveld("candies.txt");
            }
            catch (FormatException ex)
            {
                speelveld = new RegularCandies[FIELD_SIZE, FIELD_SIZE];

                InitCandies(speelveld);
            }

            PrintCandies(speelveld);

            if (ScoreRijAanwezig(speelveld))
            {
                Console.WriteLine("Ja, er is een score rij aanwezig");
            } else
            {
                Console.WriteLine("Nee, er is GEEN score rij aanwezig.");
            }

            if (ScoreKolomAanwezig(speelveld))
            {
                Console.WriteLine("Ja, er is een score kolom aanwezig");
            }
            else
            {
                Console.WriteLine("Nee, er is GEEN score kolom aanwezig.");
            }

            SchrijfSpeelveld(speelveld, "candies.txt");
            Console.ReadKey();
        }

        bool ScoreRijAanwezig(RegularCandies[,] candies)
        {
            for (int y = 0; y < FIELD_SIZE; y++)
            {
                RegularCandies candy = candies[y, 0];
                int aantal = 0;

                for (int x = 0; x < FIELD_SIZE; x++)
                {
                    if (candies[y, x] == candy)
                    {
                        aantal++;
                    } else
                    {
                        candy = candies[y, x];
                        aantal = 1;
                    }

                    if (aantal == 3)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        bool ScoreKolomAanwezig(RegularCandies[,] candies)
        {
            for (int x = 0; x < FIELD_SIZE; x++)
            {
                RegularCandies candy = candies[0, x];
                int count = 0;

                for (int y = 0; y < FIELD_SIZE; y++)
                {
                    if (candies[y, x] == candy)
                    {
                        count++;
                    } else
                    {
                        candy = candies[y, x];
                        count = 1;
                    }

                    if (count == 3)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        void InitCandies(RegularCandies[,] candies)
        {
            Random rnd = new Random();

            for (int i = 0; i < candies.Length; i++)
            {
                int candy = rnd.Next(0, 6);

                candies[i / FIELD_SIZE, i % FIELD_SIZE] = (RegularCandies)candy;
            }
        }

        void PrintCandies(RegularCandies[,] candies)
        {
            for (int y = 0; y < FIELD_SIZE; y++)
            {
                for (int x = 0; x < FIELD_SIZE; x++)
                {
                    RegularCandies candy = candies[y, x];

                    switch (candy)
                    {
                        case RegularCandies.JellyBean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case RegularCandies.Lozenge:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case RegularCandies.LemonDrop:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case RegularCandies.GumSquare:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case RegularCandies.LollipopHead:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case RegularCandies.JujubeCluster:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                    }

                    Console.Write("# ");
                }

                Console.WriteLine();
            }

            Console.ResetColor();
        }

        void SchrijfSpeelveld(RegularCandies[,] candies, string path)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path);

                for (int y = 0; y < candies.GetLength(0); y++)
                {
                    for (int x = 0; x < candies.GetLength(1); x++)
                    {
                        writer.Write("{0} ", (int)candies[y, x]);
                    }

                    writer.WriteLine();
                }
            }
            catch (IOException io)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Kon het speelveld niet opslaan. {0}", ex);
            }
            finally
            {
                writer.Close();
            }
        }

        RegularCandies[,] LeesSpeelveld(string path)
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(path);

                RegularCandies[,] candies = new RegularCandies[FIELD_SIZE, FIELD_SIZE];

                for (int y = 0; y < FIELD_SIZE; y++)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(' ');

                    for (int x = 0; x < FIELD_SIZE; x++)
                    {
                        candies[y, x] = (RegularCandies)int.Parse(parts[x]);
                    }
                }

                return candies;
            }
            finally
            {
                reader.Close();
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
