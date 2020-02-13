using System;
using System.Collections.Generic;

namespace Opdracht_2
{
    public class DeckOfCards
    {
        private List<Card> cards;

        public DeckOfCards()
        {
            cards = new List<Card>();

            InitCards();
        }

        private void InitCards()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int rank = 0; rank < 13; rank++)
                {
                    Card card = new Card(rank + 1, (CardSuit)suit);

                    cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int pos = rnd.Next(0, cards.Count);
                Card card = cards[pos];

                cards.Remove(card);
                cards.Insert(0, card);
            }
        }

        public void Print()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
