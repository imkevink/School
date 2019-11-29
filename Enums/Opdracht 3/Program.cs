using System;

namespace Opdracht_3
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
            YahtzeeGame game = new YahtzeeGame();

            game.Init();

            SpeelYahtzee(game);

            Console.ReadKey();
        }

        void SpeelYahtzee(YahtzeeGame game)
        {
            int aantalPogingen = 0;

            do
            {
                game.Gooi();
                game.ToonWorp();
                aantalPogingen++;
            } while (!game.Yahtzee());

            Console.WriteLine("Aantal pogingen nodig voor yahtzee: {0}", aantalPogingen);
        }

        int LeesInt(string vraag)
        {
            Console.Write(vraag);

            return int.Parse(Console.ReadLine());
        }

        int LeesInt(string vraag, int min, int max)
        {
            int getal = LeesInt(vraag);

            if (getal >= min && getal <= max)
            {
                return getal;
            }
            else
            {
                Console.WriteLine($"Number is not in the range: {min}..{max}.");

                return LeesInt(vraag, min, max);
            }
        }

        string LeesString(string vraag)
        {
            Console.Write(vraag);

            return Console.ReadLine();
        }
    }
}
