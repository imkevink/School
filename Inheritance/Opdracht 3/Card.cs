namespace Opdracht_3
{
    public class Card
    {
        public CardSuit suit;
        public int rank;

        public Card(int rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            switch (rank)
            {
                case 1: return $"Ace of {suit}";
                case 11: return $"Jack of {suit}";
                case 12: return $"Queen of {suit}";
                case 13: return $"King of {suit}";
                default: return $"{rank} of {suit}";
            }
        }
    }
}
