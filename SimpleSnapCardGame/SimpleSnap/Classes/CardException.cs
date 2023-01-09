using System;

namespace SimpleSnap.Classes
{
    public class CardException : Exception
    {
        public CardException(string message) : base(message)
        {

        }

        public CardException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
