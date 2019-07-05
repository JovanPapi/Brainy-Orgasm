namespace BrainyOgrasm
{
    partial class HighScoresForm
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
            this.dgvUsersScores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbVisualStudio = new System.Windows.Forms.RadioButton();
            this.rbScientists = new System.Windows.Forms.RadioButton();
            this.rbUniverse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsersScores
            // 
            this.dgvUsersScores.AllowUserToResizeColumns = false;
            this.dgvUsersScores.AllowUserToResizeRows = false;
            this.dgvUsersScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersScores.Location = new System.Drawing.Point(16, 66);
            this.dgvUsersScores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsersScores.Name = "dgvUsersScores";
            this.dgvUsersScores.Size = new System.Drawing.Size(324, 166);
            this.dgvUsersScores.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "User - Score :";
            // 
            // rbVisualStudio
            // 
            this.rbVisualStudio.AutoSize = true;
            this.rbVisualStudio.Font = new System.Drawing.Font("Arial", 9F);
            this.rbVisualStudio.Location = new System.Drawing.Point(219, 15);
            this.rbVisualStudio.Margin = new System.Windows.Forms.Padding(4);
            this.rbVisualStudio.Name = "rbVisualStudio";
            this.rbVisualStudio.Size = new System.Drawing.Size(109, 21);
            this.rbVisualStudio.TabIndex = 8;
            this.rbVisualStudio.TabStop = true;
            this.rbVisualStudio.Text = "VisualStudio";
            this.rbVisualStudio.UseVisualStyleBackColor = true;
            this.rbVisualStudio.CheckedChanged += new System.EventHandler(this.GameTypeButtons_CheckedChanged);
            // 
            // rbScientists
            // 
            this.rbScientists.AutoSize = true;
            this.rbScientists.Font = new System.Drawing.Font("Arial", 9F);
            this.rbScientists.Location = new System.Drawing.Point(115, 15);
            this.rbScientists.Margin = new System.Windows.Forms.Padding(4);
            this.rbScientists.Name = "rbScientists";
            this.rbScientists.Size = new System.Drawing.Size(93, 21);
            this.rbScientists.TabIndex = 7;
            this.rbScientists.TabStop = true;
            this.rbScientists.Text = "Scientists";
            this.rbScientists.UseVisualStyleBackColor = true;
            this.rbScientists.CheckedChanged += new System.EventHandler(this.GameTypeButtons_CheckedChanged);
            // 
            // rbUniverse
            // 
            this.rbUniverse.AutoSize = true;
            this.rbUniverse.Font = new System.Drawing.Font("Arial", 9F);
            this.rbUniverse.Location = new System.Drawing.Point(16, 15);
            this.rbUniverse.Margin = new System.Windows.Forms.Padding(4);
            this.rbUniverse.Name = "rbUniverse";
            this.rbUniverse.Size = new System.Drawing.Size(86, 21);
            this.rbUniverse.TabIndex = 6;
            this.rbUniverse.TabStop = true;
            this.rbUniverse.Text = "Universe";
            this.rbUniverse.UseVisualStyleBackColor = true;
            this.rbUniverse.CheckedChanged += new System.EventHandler(this.GameTypeButtons_CheckedChanged);
            // 
            // HighScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 249);
            this.Controls.Add(this.dgvUsersScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbVisualStudio);
            this.Controls.Add(this.rbScientists);
            this.Controls.Add(this.rbUniverse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HighScoresForm";
            this.Text = "High Scores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsersScores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbVisualStudio;
        private System.Windows.Forms.RadioButton rbScientists;
        private System.Windows.Forms.RadioButton rbUniverse;
    }
}