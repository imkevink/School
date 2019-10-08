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
            int[] getallen = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = rnd.Next(0, 200);
            }

            double gemiddelde = 0;

            for (int i = 0; i < getallen.Length; i++)
            {
                gemiddelde += getallen[i];

                Console.WriteLine($"Element {i} is {getallen[i]}");
            }

            gemiddelde /= getallen.Length;

            Console.WriteLine($"Het gemiddelde is {gemiddelde.ToString("0.00")}");

            for (int i = 0; i < getallen.Length; i++)
            {
                double getal = Math.Abs(getallen[i] - gemiddelde);

                Console.WriteLine($"Verschil gemiddelde en element {i} is {getal.ToString("0.00")}");
            }

            Console.ReadKey();
        }
    }
}
