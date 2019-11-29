using System;

namespace Opgave3
{
    class Program
    {
        const int ARRAY_LENGTH = 20;
        const int MIN = 1;
        const int MAX = 99;

        static void Main(string[] args)
        {
            int[] getallen = new int[ARRAY_LENGTH];
            Random rnd = new Random();
            int min = MAX;
            int max = MIN;

            for (int i = 0; i < getallen.Length; i++)
            {
                int getal = rnd.Next(MIN, MAX + 1);

                getallen[i] = getal;

                if (getal < min)
                {
                    min = getal;
                }

                if (getal > max)
                {
                    max = getal;
                }
            }

            Console.WriteLine($"minimum value: {min}");
            Console.WriteLine($"maximum value: {max}");

            foreach (int getal in getallen)
            {
                if (getal >= min + 20 && getal < max - 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{getal} ");
                } else if (getal >= min + 10 && getal < max - 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{getal} ");
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{getal} ");
                }
            }

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
