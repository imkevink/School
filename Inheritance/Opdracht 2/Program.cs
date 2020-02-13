using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.Start();

            Console.ReadKey();
        }

        void Start()
        {
            DeckOfCards deck = new DeckOfCards();

            deck.Print();
            Console.WriteLine();
            deck.Shuffle();
            deck.Print();
        }
    }
}
