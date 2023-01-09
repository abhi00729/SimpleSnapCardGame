using SimpleSnap.Game;
using SimpleSnap.Interfaces;
using SimpleSnap.Properties;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SimpleSnap
{
    public partial class frmSnap : Form
    {
        ISnap snapGame;

        bool firstTimeLoad = true;

        public frmSnap()
        {
            InitializeComponent();
        }

        private void btnShuffel_Click(object sender, EventArgs e)
        {   
            foreach (ICard card in snapGame.Cards)
            {
                picCardPile.Image = (Image)Resources.ResourceManager.GetObject(card.ESuite.ToString().Substring(0, 1) + card.Value.ToString());
                this.Refresh();
                Thread.Sleep(50);
            }

            picCardPile.Image = Resources.CardBack;

            btnShuffel.Enabled = false;

            btnPlayPlayer1.Enabled = true;
            btnPlayPlayer2.Enabled = true;
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            if(snapGame != null)
            {
                if (MessageBox.Show("Changing game settings will reset the game played till now. Are you sure you want to continue?", "The game will reset!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    snapGame = null;
                    ResetGame();
                    ShowGameSettings();
                }
            }
            else
            {
                ShowGameSettings();
            }
        }

        private void frmSnap_Activated(object sender, EventArgs e)
        {
            if(firstTimeLoad)
            {
                firstTimeLoad = false;
                ResetGame();
                ShowGameSettings();
            }
        }

        private void ShowGameSettings()
        {
            using (frmGame settings = new frmGame())
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    snapGame = new Snap(settings.Player1Name, settings.Player2Name);
                    snapGame.Packs = settings.Packs;
                    snapGame.SnapMethod = settings.SnapMethod;

                    snapGame.Initialise();

                    ResetGame();
                }
            }
        }

        private void ResetGame()
        {
            if (snapGame == null)
            {
                btnPlayPlayer1.Text = "Player 1";
                btnPlayPlayer2.Text = "Player 2";
                lblCardsInTheDeckValue.Text = "0";
                lblNumberOfPacksValue.Text = "0";
                lblSnapMethodValue.Text = "Not Selected";

                picCardPile.Image = null;
                picPlayer1.Image = null;
                picPlayer2.Image = null;

                btnShuffel.Enabled = false;
                btnPlayPlayer1.Enabled = false;
                btnPlayPlayer2.Enabled = false;
            }
            else
            {
                btnPlayPlayer1.Text = snapGame.Player1.Name;
                btnPlayPlayer2.Text = snapGame.Player2.Name;

                lblNumberOfPacksValue.Text = snapGame.Packs.ToString();

                switch (snapGame.SnapMethod)
                {
                    case SnapConditions.SAME_SUITE:
                        lblSnapMethodValue.Text = "Same Suit";
                        break;
                    case SnapConditions.SAME_VALUE:
                        lblSnapMethodValue.Text = "Same Face Value";
                        break;
                    case SnapConditions.SAME_SUITE_AND_VALUE:
                        lblSnapMethodValue.Text = "Same Suit And Face Value";
                        break;
                }

                txtGameResult.Text = string.Empty;

                UpdateGameDeck();

                btnShuffel.Enabled = true;
            }
        }

        private void UpdateGameDeck()
        {
            lblCardsInTheDeckValue.Text = snapGame.CardsInDeck.ToString();
        }

        private void UpdateCardAndCheckSnap(PictureBox pictureBox, ICard playedCard)
        {
            pictureBox.Image = (Image)Resources.ResourceManager.GetObject(playedCard.ESuite.ToString().Substring(0, 1) + playedCard.Value.ToString());
            UpdateGameDeck();
            this.Refresh();
            
            IPlayer winner = snapGame.CheckSnap();

            if(winner != null)
            {
                Snap(winner);

                picPlayer1.Image = null;
                picPlayer2.Image = null;
            }

            if (snapGame.CardsInDeck == 0)
            {
                picCardPile.Image = null;
                this.Refresh();
                GameUp(snapGame.PrepareResult());
            }
        }

        private void LogMessage(string msg, bool clearLog = false)
        {   
            if(clearLog)
            {
                txtGameResult.Text = string.Empty;
            }

            txtGameResult.Text += msg;
            txtGameResult.Text += Environment.NewLine;
        }

        private void frmSnap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnPlayPlayer1_Click(object sender, EventArgs e)
        {
            ICard playedCard = snapGame.Play(1);

            btnPlayPlayer1.Enabled = false;
            btnPlayPlayer2.Enabled = true;

            UpdateCardAndCheckSnap(picPlayer1, playedCard);
        }

        private void btnPlayPlayer2_Click(object sender, EventArgs e)
        {
            ICard playedCard = snapGame.Play(2);

            btnPlayPlayer2.Enabled = false;
            btnPlayPlayer1.Enabled = true;

            UpdateCardAndCheckSnap(picPlayer2, playedCard);
        }

        public void Snap(IPlayer winnerPlayer)
        {
            string msg = $"{winnerPlayer.Name} won this round. Total cards accumulated {winnerPlayer.CardsWon}.";
            
            LogMessage(msg);

            MessageBox.Show(msg + "\nClick OK to continue.", "It's a Snap!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GameUp(string result)
        {
            LogMessage(result, true);

            MessageBox.Show(result, "Game Up!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            snapGame = null;

            ResetGame();
        }

    }
}
