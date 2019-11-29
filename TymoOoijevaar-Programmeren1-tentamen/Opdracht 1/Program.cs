using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef je naam: ");
            string naam = Console.ReadLine();

            Console.Write("geef jouw aantal vrijstelling EC's: ");
            int vrijstellingECs = int.Parse(Console.ReadLine());

            Console.Write("geef jouw totaal aantal EC's van jaar 1: ");
            int totaalECs = int.Parse(Console.ReadLine());

            double vereist = (60 - vrijstellingECs) * 0.75 + vrijstellingECs;
            Console.WriteLine($"(vereist aantal EC's om naar jaar 2 te mogen: {vereist})");

            if (totaalECs >= vereist)
            {
                Console.WriteLine($"{naam}, je hebt genoeg EC's om door te mogen naar jaar 2.");
            } else
            {
                Console.WriteLine($"{naam}, je hebt (nog) niet genoeg EC's om door te mogen naar jaar 2.");
            }

            Console.ReadKey();
        }
    }
}
