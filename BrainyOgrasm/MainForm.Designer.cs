namespace BrainyOgrasm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.pbLogoOfTheGame = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.MoveImages = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoOfTheGame)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHighScores
            // 
            this.btnHighScores.Font = new System.Drawing.Font("Arial", 15F);
            this.btnHighScores.Location = new System.Drawing.Point(12, 203);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(344, 41);
            this.btnHighScores.TabIndex = 7;
            this.btnHighScores.Text = "High scores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // pbLogoOfTheGame
            // 
            this.pbLogoOfTheGame.Location = new System.Drawing.Point(123, 38);
            this.pbLogoOfTheGame.Name = "pbLogoOfTheGame";
            this.pbLogoOfTheGame.Size = new System.Drawing.Size(119, 102);
            this.pbLogoOfTheGame.TabIndex = 9;
            this.pbLogoOfTheGame.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 17F);
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Brainy Orgasm";
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Font = new System.Drawing.Font("Arial", 15F);
            this.btnHowToPlay.Location = new System.Drawing.Point(12, 262);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(344, 41);
            this.btnHowToPlay.TabIndex = 6;
            this.btnHowToPlay.Text = "How to play";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Arial", 15F);
            this.btnNewGame.Location = new System.Drawing.Point(12, 146);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(344, 41);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // MoveImages
            // 
            this.MoveImages.Enabled = true;
            this.MoveImages.Interval = 500;
            this.MoveImages.Tick += new System.EventHandler(this.MoveImages_Tick);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 15F);
            this.btnExit.Location = new System.Drawing.Point(12, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(344, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Location = new System.Drawing.Point(11, 9);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(95, 131);
            this.panelLeft.TabIndex = 11;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelsLeftRight_DrawImages);
            // 
            // panelRight
            // 
            this.panelRight.Location = new System.Drawing.Point(264, 9);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(95, 131);
            this.panelRight.TabIndex = 12;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelsLeftRight_DrawImages);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnNewGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(372, 370);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.pbLogoOfTheGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoOfTheGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.PictureBox pbLogoOfTheGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Timer MoveImages;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
    }
}

