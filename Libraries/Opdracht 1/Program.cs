using System;
using MyTools;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Start();
        }

        void Start()
        {
            int getal = ReadTools.ReadInt("tik een getal: ");
            Console.WriteLine("Je hebt {0} ingetikt.", getal);

            int leeftijd = ReadTools.ReadInt("hoe oud ben je? ", 0, 120);
            Console.WriteLine("Je bent {0} jaar oud.", leeftijd);

            string naam = ReadTools.ReadString("hoe heet je? ");
            Console.WriteLine("Aangenaam kennis met je te maken, {0}.", naam);

            Console.ReadKey();
        }
    }
}
