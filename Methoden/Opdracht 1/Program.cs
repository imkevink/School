using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de prijs: ");
            float prijs = float.Parse(Console.ReadLine());
            float btw = BerekenBtw(prijs);
            float totaal = prijs + btw;

            Console.WriteLine($"Prijs: {prijs}, btw: {btw}, totaal: {totaal}");
            Console.ReadKey();
        }

        static float BerekenBtw(float prijs)
        {
            const float BTW = 0.21f;

            return prijs * BTW;
        }
    }
}
