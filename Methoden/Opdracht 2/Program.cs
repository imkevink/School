using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            int getal = int.Parse(Console.ReadLine());

            while (getal != 0)
            {
                if (getal > 0)
                {
                    bool isPriem = IsPriemGetal(getal);

                    if (isPriem)
                        Console.WriteLine($"{getal} is een priemgetal");
                    else
                        Console.WriteLine($"{getal} is geen priemgetal");
                }

                Console.Write("Geef een getal: ");
                getal = int.Parse(Console.ReadLine());
            }
        }

        static bool IsPriemGetal(int getal)
        {
            for (int i = 2; i < getal; i++)
            {
                if (getal % i == 0) return false;
            }

            return true;
        }
    }
}
