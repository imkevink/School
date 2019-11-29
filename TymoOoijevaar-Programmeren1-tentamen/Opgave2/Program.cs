using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("voer een getal in: ");
            int getal = int.Parse(Console.ReadLine());

            while (getal >= 1)
            {
                int factor = 2;

                while (getal > 1)
                {
                    if (getal % factor == 0)
                    {
                        getal /= factor;
                        Console.Write($"{factor} ");
                    } else
                    {
                        factor++;
                    }
                }

                Console.Write("\nvoer een getal in: ");
                getal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("einde programma");
            Console.ReadKey();
        }
    }
}
