using SimpleSnap.Classes;
using SimpleSnap.Interfaces;
using System;

namespace SimpleSnap.Game
{
    public class Snap : ISnap
    {
        private readonly Random _randomPlayer = new Random();

        private IPlayer _player1, _player2;

        public IPlayer Player1 { get => _player1; }
        public IPlayer Player2 { get => _player2; }
        public int Packs { get; set; }
        public SnapConditions SnapMethod { get; set; }

        public IDeck Deck { get; set; }

        public Snap(string Player1Name, string Player2Name)
        {
            _player1 = new Player(Player1Name);
            _player2 = new Player(Player2Name);
        }

        public ICard[] Cards
        {
            get => Deck.Cards;
        }

        public int CardsInDeck { get => Deck.CardsRemainingInDeck; }

        public void Initialise()
        {
            Deck = new DeckofCards(Packs);
            Deck.CreateDeck();
            Deck.ShuffleDeck();
        }

        public bool IsSnap(SnapConditions snapMethod, ICard card1, ICard card2)
        {
            if(card1 == null || card2 == null)
            {
                return false;
            }

            switch (snapMethod)
            {
                case SnapConditions.SAME_SUITE:
                    return (card1.Suite == card2.Suite);
                case SnapConditions.SAME_VALUE:
                    return (card1.Value == card2.Value);
                case SnapConditions.SAME_SUITE_AND_VALUE:
                    return (card1.Suite == card2.Suite && card1.Value == card2.Value);
                default:
                    throw new CardException("Invalid Snap Method");
            }
        }

        private IPlayer WinningPlayer { get => _randomPlayer.Next(1000000) % 2 == 0 ? _player1 : _player2; }

        public ICard Play(int player)
        {
            ICard card = Deck.DealCard();

            if (player == 1)
            {
                _player1.CurrentCard = card;
            }
            else
            {
                _player2.CurrentCard = card;
            }

            return card;
        }

        public IPlayer CheckSnap()
        {
            IPlayer winnerPlayer = null;

            if (IsSnap(SnapMethod, _player1.CurrentCard, _player2.CurrentCard))
            {
                winnerPlayer = WinningPlayer;

                winnerPlayer.CardsWon += Deck.NoOfCardsInPlay;
                ++winnerPlayer.Wins;

                Deck.ClearCardsInPlay();

                _player1.CurrentCard = null;
                _player2.CurrentCard = null;
            }

            return winnerPlayer;
        }

        public string PrepareResult()
        {
            string result;

            if (_player1.CardsWon > _player2.CardsWon)
            {
                result = $"{_player1.Name} wins the game by {_player1.CardsWon} cards to {_player2.CardsWon} cards of {Player2.Name}!";
            }
            else if (_player1.CardsWon < _player2.CardsWon)
            {
                result = $"{_player2.Name} wins the game by {_player2.CardsWon} cards to {_player1.CardsWon} cards of {Player1.Name}!";
            }
            else
            {
                result = $"It is a draw by {_player1.CardsWon} cards of {_player1.Name} to {_player2.CardsWon} cards of {_player2.Name}!";
            }

            return result;
        }

    }
}
