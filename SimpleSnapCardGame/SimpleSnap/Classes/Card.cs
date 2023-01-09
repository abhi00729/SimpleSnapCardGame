using SimpleSnap.Interfaces;

namespace SimpleSnap.Classes
{
    public class Card : ICard
    {
        public Card (CardSuite suite, CardValue value)
        {
            this.ESuite = suite;
            this.EValue = value;
        }

        public int Suite { get => (int) ESuite; }
        public int Value { get => (int) EValue; }

        public CardSuite ESuite { get; }
        public CardValue EValue { get; }
    }
}
