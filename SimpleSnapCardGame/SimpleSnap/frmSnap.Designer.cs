
namespace SimpleSnap
{
    partial class frmSnap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnap));
            this.picCardPile = new System.Windows.Forms.PictureBox();
            this.lblCardsInTheDeck = new System.Windows.Forms.Label();
            this.btnShuffel = new System.Windows.Forms.Button();
            this.lblCardsInTheDeckValue = new System.Windows.Forms.Label();
            this.btnGame = new System.Windows.Forms.Button();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.btnPlayPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayPlayer2 = new System.Windows.Forms.Button();
            this.lblNumberOfPacksValue = new System.Windows.Forms.Label();
            this.lblNumberOfPacks = new System.Windows.Forms.Label();
            this.lblSnapMethodValue = new System.Windows.Forms.Label();
            this.lblSnapMethod = new System.Windows.Forms.Label();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.txtGameResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCardPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // picCardPile
            // 
            this.picCardPile.BackColor = System.Drawing.Color.White;
            this.picCardPile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCardPile.BackgroundImage")));
            this.picCardPile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCardPile.Location = new System.Drawing.Point(12, 37);
            this.picCardPile.Name = "picCardPile";
            this.picCardPile.Size = new System.Drawing.Size(167, 240);
            this.picCardPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCardPile.TabIndex = 0;
            this.picCardPile.TabStop = false;
            // 
            // lblCardsInTheDeck
            // 
            this.lblCardsInTheDeck.AutoSize = true;
            this.lblCardsInTheDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardsInTheDeck.Location = new System.Drawing.Point(12, 9);
            this.lblCardsInTheDeck.Name = "lblCardsInTheDeck";
            this.lblCardsInTheDeck.Size = new System.Drawing.Size(200, 25);
            this.lblCardsInTheDeck.TabIndex = 1;
            this.lblCardsInTheDeck.Text = "Cards in the Deck";
            // 
            // btnShuffel
            // 
            this.btnShuffel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShuffel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShuffel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffel.Location = new System.Drawing.Point(186, 234);
            this.btnShuffel.Name = "btnShuffel";
            this.btnShuffel.Size = new System.Drawing.Size(140, 43);
            this.btnShuffel.TabIndex = 2;
            this.btnShuffel.Text = "Shuffel";
            this.btnShuffel.UseVisualStyleBackColor = false;
            this.btnShuffel.Click += new System.EventHandler(this.btnShuffel_Click);
            // 
            // lblCardsInTheDeckValue
            // 
            this.lblCardsInTheDeckValue.AutoSize = true;
            this.lblCardsInTheDeckValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCardsInTheDeckValue.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardsInTheDeckValue.Location = new System.Drawing.Point(218, 1);
            this.lblCardsInTheDeckValue.Name = "lblCardsInTheDeckValue";
            this.lblCardsInTheDeckValue.Size = new System.Drawing.Size(37, 41);
            this.lblCardsInTheDeckValue.TabIndex = 3;
            this.lblCardsInTheDeckValue.Text = "0";
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.Location = new System.Drawing.Point(622, 614);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(105, 43);
            this.btnGame.TabIndex = 4;
            this.btnGame.Text = "Game";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // picPlayer1
            // 
            this.picPlayer1.BackColor = System.Drawing.Color.White;
            this.picPlayer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlayer1.BackgroundImage")));
            this.picPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer1.Location = new System.Drawing.Point(12, 306);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(167, 240);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer1.TabIndex = 5;
            this.picPlayer1.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackColor = System.Drawing.Color.White;
            this.picPlayer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlayer2.BackgroundImage")));
            this.picPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer2.Location = new System.Drawing.Point(185, 306);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(167, 240);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer2.TabIndex = 6;
            this.picPlayer2.TabStop = false;
            // 
            // btnPlayPlayer1
            // 
            this.btnPlayPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlayPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPlayer1.Location = new System.Drawing.Point(12, 552);
            this.btnPlayPlayer1.Name = "btnPlayPlayer1";
            this.btnPlayPlayer1.Size = new System.Drawing.Size(167, 43);
            this.btnPlayPlayer1.TabIndex = 7;
            this.btnPlayPlayer1.Text = "Player 1";
            this.btnPlayPlayer1.UseVisualStyleBackColor = false;
            this.btnPlayPlayer1.Click += new System.EventHandler(this.btnPlayPlayer1_Click);
            // 
            // btnPlayPlayer2
            // 
            this.btnPlayPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlayPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPlayer2.Location = new System.Drawing.Point(186, 552);
            this.btnPlayPlayer2.Name = "btnPlayPlayer2";
            this.btnPlayPlayer2.Size = new System.Drawing.Size(166, 43);
            this.btnPlayPlayer2.TabIndex = 8;
            this.btnPlayPlayer2.Text = "Player 2";
            this.btnPlayPlayer2.UseVisualStyleBackColor = false;
            this.btnPlayPlayer2.Click += new System.EventHandler(this.btnPlayPlayer2_Click);
            // 
            // lblNumberOfPacksValue
            // 
            this.lblNumberOfPacksValue.AutoSize = true;
            this.lblNumberOfPacksValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNumberOfPacksValue.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPacksValue.Location = new System.Drawing.Point(267, 64);
            this.lblNumberOfPacksValue.Name = "lblNumberOfPacksValue";
            this.lblNumberOfPacksValue.Size = new System.Drawing.Size(37, 41);
            this.lblNumberOfPacksValue.TabIndex = 10;
            this.lblNumberOfPacksValue.Text = "0";
            // 
            // lblNumberOfPacks
            // 
            this.lblNumberOfPacks.AutoSize = true;
            this.lblNumberOfPacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPacks.Location = new System.Drawing.Point(185, 72);
            this.lblNumberOfPacks.Name = "lblNumberOfPacks";
            this.lblNumberOfPacks.Size = new System.Drawing.Size(76, 25);
            this.lblNumberOfPacks.TabIndex = 9;
            this.lblNumberOfPacks.Text = "Packs";
            // 
            // lblSnapMethodValue
            // 
            this.lblSnapMethodValue.AutoSize = true;
            this.lblSnapMethodValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSnapMethodValue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnapMethodValue.Location = new System.Drawing.Point(303, 118);
            this.lblSnapMethodValue.Name = "lblSnapMethodValue";
            this.lblSnapMethodValue.Size = new System.Drawing.Size(181, 32);
            this.lblSnapMethodValue.TabIndex = 12;
            this.lblSnapMethodValue.Text = "Not Selected";
            this.lblSnapMethodValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSnapMethod
            // 
            this.lblSnapMethod.AutoSize = true;
            this.lblSnapMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnapMethod.Location = new System.Drawing.Point(185, 122);
            this.lblSnapMethod.Name = "lblSnapMethod";
            this.lblSnapMethod.Size = new System.Drawing.Size(112, 25);
            this.lblSnapMethod.TabIndex = 11;
            this.lblSnapMethod.Text = "Condition";
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameResult.Location = new System.Drawing.Point(355, 241);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(147, 25);
            this.lblGameResult.TabIndex = 13;
            this.lblGameResult.Text = "Game Status";
            // 
            // txtGameResult
            // 
            this.txtGameResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtGameResult.Location = new System.Drawing.Point(360, 270);
            this.txtGameResult.Multiline = true;
            this.txtGameResult.Name = "txtGameResult";
            this.txtGameResult.ReadOnly = true;
            this.txtGameResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGameResult.Size = new System.Drawing.Size(367, 325);
            this.txtGameResult.TabIndex = 14;
            // 
            // frmSnap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(736, 666);
            this.Controls.Add(this.txtGameResult);
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.lblSnapMethodValue);
            this.Controls.Add(this.lblSnapMethod);
            this.Controls.Add(this.lblNumberOfPacksValue);
            this.Controls.Add(this.lblNumberOfPacks);
            this.Controls.Add(this.btnPlayPlayer2);
            this.Controls.Add(this.btnPlayPlayer1);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.lblCardsInTheDeckValue);
            this.Controls.Add(this.btnShuffel);
            this.Controls.Add(this.lblCardsInTheDeck);
            this.Controls.Add(this.picCardPile);
            this.Name = "frmSnap";
            this.Text = "Snap!";
            this.Activated += new System.EventHandler(this.frmSnap_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSnap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picCardPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCardPile;
        private System.Windows.Forms.Label lblCardsInTheDeck;
        private System.Windows.Forms.Button btnShuffel;
        private System.Windows.Forms.Label lblCardsInTheDeckValue;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.Button btnPlayPlayer1;
        private System.Windows.Forms.Button btnPlayPlayer2;
        private System.Windows.Forms.Label lblNumberOfPacksValue;
        private System.Windows.Forms.Label lblNumberOfPacks;
        private System.Windows.Forms.Label lblSnapMethodValue;
        private System.Windows.Forms.Label lblSnapMethod;
        private System.Windows.Forms.Label lblGameResult;
        private System.Windows.Forms.TextBox txtGameResult;
    }
}

