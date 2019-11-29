using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int getal1 = rnd.Next(1, 51);
                int getal2 = rnd.Next(1, 6);
                int quotient = IntegerDeling(getal1, getal2, out int rest);

                Console.WriteLine($"{getal1} / {getal2} = {quotient} ({rest})");
            }

            Console.WriteLine("einde programma");
            Console.ReadKey();
        }

        static int IntegerDeling(int getal1, int getal2, out int rest)
        {
            int quotient = 0;

            while (getal1 >= getal2)
            {
                getal1 -= getal2;
                quotient++;
            }

            rest = getal1;

            return quotient;
        }
    }
}
