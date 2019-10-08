using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het vak: ");
            string vak = Console.ReadLine();

            Console.Write("Geef het aantal studenten: ");
            int aantal = int.Parse(Console.ReadLine());
            string[] namen = new string[aantal];
            
            for (int i = 0; i < aantal; i++)
            {
                Console.Write($"Geef de naam van de {i + 1}e student: ");
                namen[i] = Console.ReadLine();
            }

            double[] cijfers = new double[aantal];
            double gemiddelde = 0;
            double hoogste = 0;
            int hoogsteIndex = 0;

            for (int i = 0; i < aantal; i++)
            {
                Console.Write($"Geef het cijfer van {namen[i]}: ");
                cijfers[i] = double.Parse(Console.ReadLine());

                gemiddelde += cijfers[i];

                if (cijfers[i] > hoogste)
                {
                    hoogste = cijfers[i];
                    hoogsteIndex = i;
                }
            }

            gemiddelde /= aantal;

            Console.WriteLine($"Het gemiddelde cijfer is {gemiddelde}");
            Console.WriteLine($"Het hoogste cijfer is {hoogste} en is behaald door {namen[hoogsteIndex]}");

            for (int i = 0; i < aantal; i++)
            {
                Console.WriteLine($"Student {namen[i]} heeft voor {vak} het cijfer {cijfers[i]}");
            }

            Console.ReadKey();
        }
    }
}
