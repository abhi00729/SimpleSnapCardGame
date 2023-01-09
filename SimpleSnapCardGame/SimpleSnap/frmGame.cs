using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimpleSnap
{
    public partial class frmGame : Form
    {
        SnapConditions _snapMethod = SnapConditions.SAME_VALUE;

        public frmGame()
        {
            InitializeComponent();
        }

        public string Player1Name { get => txtPlayer1Name.Text; }
        public string Player2Name { get => txtPlayer2Name.Text; }

        public int Packs { get => (int)nudNumberofPacks.Value; }

        public SnapConditions SnapMethod { get => _snapMethod; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void rbSameFaceValue_CheckedChanged(object sender, EventArgs e)
        {
            _snapMethod = SnapConditions.SAME_VALUE;
        }

        private void rbSameSuite_CheckedChanged(object sender, EventArgs e)
        {
            _snapMethod = SnapConditions.SAME_SUITE;
        }

        private void rbBoth_CheckedChanged(object sender, EventArgs e)
        {
            _snapMethod = SnapConditions.SAME_SUITE_AND_VALUE;
        }

        private void btnStart_Validating(object sender, CancelEventArgs e)
        {
            bool validationFailed = false;

            if (string.IsNullOrEmpty(txtPlayer1Name.Text))
            {
                MessageBox.Show("Player 1 Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                validationFailed = true;
            }
            else if (string.IsNullOrEmpty(txtPlayer2Name.Text))
            {
                MessageBox.Show("Player 2 Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                validationFailed = true;
            }
            else if (txtPlayer1Name.Text.Equals(txtPlayer2Name.Text, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Both players should have different names.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                validationFailed = true;
            }

            e.Cancel = validationFailed;
        }
    }
}
