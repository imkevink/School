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

        void Start()
        {
            Console.Write("Geef een zoekwoord: ");
            string woord = Console.ReadLine();
            int aantal = ZoekWoordInBestand("tweets.txt", woord);

            Console.WriteLine("Aantal regels die het woord bevatten: {0}", aantal);
            Console.ReadKey();
        }

        bool ZitWoordInRegel(string regel, string woord)
        {
            return regel.ToLower().Contains(woord.ToLower());
        }

        int ZoekWoordInBestand(string path, string woord)
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(path);

                int aantal = 0;

                while (!reader.EndOfStream)
                {
                    string regel = reader.ReadLine();

                    if (ZitWoordInRegel(regel, woord))
                    {
                        aantal++;

                        ToonWoordInRegel(regel, woord);
                    }
                }

                return aantal;
            }
            catch
            {
                Console.WriteLine("Kon bestand {0} niet lezen", path);

                return 0;
            }
            finally
            {
                reader.Close();
            }
        }

        void ToonWoordInRegel(string regel, string woord)
        {
            while (regel.Length != 0)
            {
                int index = regel.IndexOf(woord, StringComparison.OrdinalIgnoreCase);

                if (index < 0)
                {
                    Console.WriteLine(regel);
                    break;
                }
                else
                {

                    Console.Write(regel.Substring(0, index));
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(regel.Substring(index, woord.Length));
                    Console.ResetColor();

                    regel = regel.Substring(index + woord.Length);
                }
            }
        }
    }
}
