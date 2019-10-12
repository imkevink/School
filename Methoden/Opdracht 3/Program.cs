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
            Console.Write("Geef een jaartal: ");
            int jaartal = int.Parse(Console.ReadLine());

            while (jaartal != 0)
            {
                if (IsSchrikkelJaar(jaartal))
                    Console.WriteLine($"Het jaar {jaartal} is een schrikkeljaar");
                else
                    Console.WriteLine($"Het jaar {jaartal} is niet een schrikkeljaar");

                Console.Write("Geef een jaartal: ");
                jaartal = int.Parse(Console.ReadLine());
            }
        }

        static bool IsSchrikkelJaar(int jaartal)
        {
            return jaartal % 400 == 0 || (
                jaartal % 4 == 0 && jaartal % 100 != 0
            );
        }
    }
}
