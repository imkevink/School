using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[20];

            for (int i = 0; i < getallen.Length; i++)
            {
                Console.Write("Geef een getal: ");
                int getal = int.Parse(Console.ReadLine());

                if (getal == 0) break;

                getallen[i] = getal;
            }

            Console.Write("Geef de zoekwaarde: ");
            int zoek = int.Parse(Console.ReadLine());
            int aantal = 0;

            foreach (int getal in getallen)
            {
                if (getal == zoek) aantal++;
            }

            Console.WriteLine($"De zoekwaarde komt {aantal} keer voor");
            Console.ReadKey();
        }
    }
}
