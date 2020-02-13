using System;

namespace Opdracht_3
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
            Player player1 = new Player("John");
            Player player2 = new Player("Emma");

            WarCardGame game = new WarCardGame(player1, player2);

            PlayTheGame(game);
        }

        void PlayTheGame(WarCardGame game)
        {
            game.StartNewGame();

            while (!game.EndOfGame())
            {
                game.NextCard();
            }

            if (game.player1.cards.Count != 0)
                Console.WriteLine($"{game.player1.name} has won!");
            else
                Console.WriteLine($"{game.player2.name} has won!");
        }
    }
}
