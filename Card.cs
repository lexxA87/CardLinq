namespace CardLinq
{
    public class Card
    {
        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }

        public string Name
        {
            get
            {
                return $"{Value} of {Suit}";
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
