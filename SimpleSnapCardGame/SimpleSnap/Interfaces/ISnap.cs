
namespace SimpleSnap.Interfaces
{
    public interface ISnap
    {
        IPlayer Player1 { get; }
        IPlayer Player2 { get; }
        int Packs { get; set; }
        SnapConditions SnapMethod { get; set; }
        void Initialise();
        ICard Play(int player);
        IPlayer CheckSnap();
        string PrepareResult();
        ICard[] Cards { get; }
        int CardsInDeck { get; }
    }
}