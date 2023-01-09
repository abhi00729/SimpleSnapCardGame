
namespace SimpleSnap
{
    partial class frmGame
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
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.nudNumberofPacks = new System.Windows.Forms.NumericUpDown();
            this.lblNumberofPacks = new System.Windows.Forms.Label();
            this.grpSnapMethod = new System.Windows.Forms.GroupBox();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.rbSameSuite = new System.Windows.Forms.RadioButton();
            this.rbSameFaceValue = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberofPacks)).BeginInit();
            this.grpSnapMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(166, 25);
            this.lblPlayer1Name.TabIndex = 2;
            this.lblPlayer1Name.Text = "Player 1 Name";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1Name.Location = new System.Drawing.Point(210, 6);
            this.txtPlayer1Name.MaxLength = 100;
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(243, 31);
            this.txtPlayer1Name.TabIndex = 3;
            this.txtPlayer1Name.Text = "Player1";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2Name.Location = new System.Drawing.Point(210, 43);
            this.txtPlayer2Name.MaxLength = 100;
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(243, 31);
            this.txtPlayer2Name.TabIndex = 5;
            this.txtPlayer2Name.Text = "Player2";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.Location = new System.Drawing.Point(12, 46);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(166, 25);
            this.lblPlayer2Name.TabIndex = 4;
            this.lblPlayer2Name.Text = "Player 2 Name";
            // 
            // nudNumberofPacks
            // 
            this.nudNumberofPacks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nudNumberofPacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberofPacks.Location = new System.Drawing.Point(210, 80);
            this.nudNumberofPacks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberofPacks.Name = "nudNumberofPacks";
            this.nudNumberofPacks.Size = new System.Drawing.Size(120, 31);
            this.nudNumberofPacks.TabIndex = 6;
            this.nudNumberofPacks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumberofPacks
            // 
            this.lblNumberofPacks.AutoSize = true;
            this.lblNumberofPacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofPacks.Location = new System.Drawing.Point(12, 83);
            this.lblNumberofPacks.Name = "lblNumberofPacks";
            this.lblNumberofPacks.Size = new System.Drawing.Size(191, 25);
            this.lblNumberofPacks.TabIndex = 7;
            this.lblNumberofPacks.Text = "Number of Packs";
            // 
            // grpSnapMethod
            // 
            this.grpSnapMethod.Controls.Add(this.rbBoth);
            this.grpSnapMethod.Controls.Add(this.rbSameSuite);
            this.grpSnapMethod.Controls.Add(this.rbSameFaceValue);
            this.grpSnapMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSnapMethod.Location = new System.Drawing.Point(17, 117);
            this.grpSnapMethod.Name = "grpSnapMethod";
            this.grpSnapMethod.Size = new System.Drawing.Size(436, 143);
            this.grpSnapMethod.TabIndex = 9;
            this.grpSnapMethod.TabStop = false;
            this.grpSnapMethod.Text = "Snap Condition";
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Location = new System.Drawing.Point(7, 101);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(78, 29);
            this.rbBoth.TabIndex = 2;
            this.rbBoth.Text = "Both";
            this.rbBoth.UseVisualStyleBackColor = true;
            this.rbBoth.CheckedChanged += new System.EventHandler(this.rbBoth_CheckedChanged);
            // 
            // rbSameSuite
            // 
            this.rbSameSuite.AutoSize = true;
            this.rbSameSuite.Location = new System.Drawing.Point(7, 66);
            this.rbSameSuite.Name = "rbSameSuite";
            this.rbSameSuite.Size = new System.Drawing.Size(150, 29);
            this.rbSameSuite.TabIndex = 1;
            this.rbSameSuite.Text = "Same Suite";
            this.rbSameSuite.UseVisualStyleBackColor = true;
            this.rbSameSuite.CheckedChanged += new System.EventHandler(this.rbSameSuite_CheckedChanged);
            // 
            // rbSameFaceValue
            // 
            this.rbSameFaceValue.AutoSize = true;
            this.rbSameFaceValue.Checked = true;
            this.rbSameFaceValue.Location = new System.Drawing.Point(7, 31);
            this.rbSameFaceValue.Name = "rbSameFaceValue";
            this.rbSameFaceValue.Size = new System.Drawing.Size(215, 29);
            this.rbSameFaceValue.TabIndex = 0;
            this.rbSameFaceValue.TabStop = true;
            this.rbSameFaceValue.Text = "Same Face Value";
            this.rbSameFaceValue.UseVisualStyleBackColor = true;
            this.rbSameFaceValue.CheckedChanged += new System.EventHandler(this.rbSameFaceValue_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(225, 266);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 43);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.Validating += new System.ComponentModel.CancelEventHandler(this.btnStart_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(348, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 43);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmGame
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(467, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpSnapMethod);
            this.Controls.Add(this.lblNumberofPacks);
            this.Controls.Add(this.nudNumberofPacks);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberofPacks)).EndInit();
            this.grpSnapMethod.ResumeLayout(false);
            this.grpSnapMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.NumericUpDown nudNumberofPacks;
        private System.Windows.Forms.Label lblNumberofPacks;
        private System.Windows.Forms.GroupBox grpSnapMethod;
        private System.Windows.Forms.RadioButton rbSameFaceValue;
        private System.Windows.Forms.RadioButton rbBoth;
        private System.Windows.Forms.RadioButton rbSameSuite;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
    }
}