using SimpleSnap.Interfaces;

namespace SimpleSnap.Classes
{
    public class Player : IPlayer
    {
        //Can add more player details
        public string Name { get; set; }
        public int Wins { get; set; }
        public int CardsWon { get; set; }
        public ICard CurrentCard { get; set; }
        
        public Player(string name)
        {
            Name = name;
        }
    }
}
