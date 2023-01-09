
namespace SimpleSnap
{
    public enum SnapConditions 
    { 
        SAME_SUITE, 
        SAME_VALUE, 
        SAME_SUITE_AND_VALUE 
    }

    public enum CardSuite
    {
        Club = 0,
        Spade = 1,
        Heart = 2,
        Diamond = 3
    }

    public enum CardValue
    {
        //Joker,
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}
