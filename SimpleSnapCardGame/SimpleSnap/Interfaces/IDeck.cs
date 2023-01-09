
namespace SimpleSnap.Interfaces
{
    public interface IDeck
    {
        int NoOfCardsInPlay { get; }
        int CardsRemainingInDeck { get; }
        IDeck CreateDeck ();
        IDeck ShuffleDeck ();
        ICard DealCard();
        ICard[] Cards { get; }

        void ClearCardsInPlay();
    }
}
