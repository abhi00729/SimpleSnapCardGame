
namespace SimpleSnap.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Wins { get; set; }
        int CardsWon { get; set; }
        ICard CurrentCard { get; set; }
    }
}