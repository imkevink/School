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
            int[] getallen = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = rnd.Next(0, 150);
            }

            int kleinste = int.MaxValue;

            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] < kleinste)
                {
                    kleinste = getallen[i];
                }

                Console.WriteLine($"Element {i} is {getallen[i]}");
            }

            int aantal = 0;

            foreach (int getal in getallen)
            {
                if (getal == kleinste)
                {
                    aantal++;
                }
            }

            Console.WriteLine($"Het kleinste getal is {kleinste} en komt {aantal} keer voor");
            Console.ReadKey();
        }
    }
}
