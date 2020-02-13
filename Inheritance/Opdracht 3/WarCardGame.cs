using System;

namespace Opdracht_3
{
    public class WarCardGame : CardGame
    {
        public Player player1;
        public Player player2;

        public WarCardGame(Player p1, Player p2)
        {
            player1 = p1;
            player2 = p2;
        }

        public void StartNewGame()
        {
            deck.Shuffle();

            for (int i = 0; i < deck.cards.Count; i++)
            {
                if (i % 2 == 0)
                    player1.AddCard(deck.cards[i]);
                else
                    player2.AddCard(deck.cards[i]);
            }
        }

        public bool EndOfGame()
        {
            return player1.cards.Count == 0 || player2.cards.Count == 0;
        }

        public void NextCard()
        {
            Card card1 = player1.GetNextCard();
            Card card2 = player2.GetNextCard();

            Console.WriteLine($"[{player1.name}] {card1} - [{player2.name}] {card2}");

            if (card1.rank > card2.rank)
            {
                Console.WriteLine($"{player1.name} got the cards");

                player1.AddCard(card1);
                player1.AddCard(card2);
            }
            else if (card2.rank > card1.rank)
            {
                Console.WriteLine($"{player2.name} got the cards");

                player2.AddCard(card2);
                player2.AddCard(card1);
            }
            else
            {
                Console.WriteLine("2 cards lost...");
                Console.WriteLine($"cards left: [{player1.name}] {player1.cards.Count}x, [{player2.name}] {player2.cards.Count}x");
            }
        }
    }
}
