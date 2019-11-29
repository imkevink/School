using System;

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
            PrintMaanden();

            Maand maand = VraagMaand("Voer een maandnummer in: ");

            Console.Write($"{(int)maand} => ");
            PrintMaand(maand);

            Console.ReadKey();
        }

        int LeesInt(string vraag)
        {
            Console.Write(vraag);

            return int.Parse(Console.ReadLine());
        }

        int LeesInt(string vraag, int min, int max)
        {
            int getal = LeesInt(vraag);

            if (getal >= min && getal <= max) {
                return getal;
            } else
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

        Maand VraagMaand(string vraag)
        {
            int maand = LeesInt(vraag);

            if (Enum.IsDefined(typeof(Maand), maand))
            {
                return (Maand)maand;
            } else
            {
                Console.WriteLine($"{maand} is geen geldige waarde.");

                return VraagMaand(vraag);
            }
        }

        void PrintMaanden()
        {
            for (Maand maand = Maand.Januari; maand <= Maand.December; maand++)
            {
                Console.Write("{0,2} - ", (int)maand);
                PrintMaand(maand);
            }
        }

        void PrintMaand(Maand maand)
        {
            switch (maand) {
                case Maand.Januari:
                    Console.WriteLine("Januari");
                    break;
                case Maand.Februari:
                    Console.WriteLine("Februari");
                    break;
                case Maand.Maart:
                    Console.WriteLine("Maart");
                    break;
                case Maand.April:
                    Console.WriteLine("April");
                    break;
                case Maand.Mei:
                    Console.WriteLine("Mei");
                    break;
                case Maand.Juni:
                    Console.WriteLine("Juni");
                    break;
                case Maand.Juli:
                    Console.WriteLine("Juli");
                    break;
                case Maand.Augustus:
                    Console.WriteLine("Augustus");
                    break;
                case Maand.September:
                    Console.WriteLine("September");
                    break;
                case Maand.Oktober:
                    Console.WriteLine("Oktober");
                    break;
                case Maand.November:
                    Console.WriteLine("November");
                    break;
                case Maand.December:
                    Console.WriteLine("December");
                    break;
            }
        }
    }
}
