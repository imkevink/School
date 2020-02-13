using System;
using System.Collections.Generic;

namespace Opdracht_3
{
    public class Player
    {
        public string name;
        public List<Card> cards;

        public Player(string name)
        {
            this.name = name;
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public Card GetNextCard()
        {
            Card card = cards[0];

            cards.RemoveAt(0);

            return card;
        }
    }
}
