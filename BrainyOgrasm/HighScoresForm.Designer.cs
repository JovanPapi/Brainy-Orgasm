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
            this.rbPornStars = new System.Windows.Forms.RadioButton();
            this.rbDinosaurs = new System.Windows.Forms.RadioButton();
            this.rbUniverse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsersScores
            // 
            this.dgvUsersScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersScores.Location = new System.Drawing.Point(12, 54);
            this.dgvUsersScores.Name = "dgvUsersScores";
            this.dgvUsersScores.Size = new System.Drawing.Size(243, 135);
            this.dgvUsersScores.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "User - Score :";
            // 
            // rbPornStars
            // 
            this.rbPornStars.AutoSize = true;
            this.rbPornStars.Font = new System.Drawing.Font("Arial", 9F);
            this.rbPornStars.Location = new System.Drawing.Point(182, 12);
            this.rbPornStars.Name = "rbPornStars";
            this.rbPornStars.Size = new System.Drawing.Size(80, 19);
            this.rbPornStars.TabIndex = 8;
            this.rbPornStars.TabStop = true;
            this.rbPornStars.Text = "PornStars";
            this.rbPornStars.UseVisualStyleBackColor = true;
            this.rbPornStars.CheckedChanged += new System.EventHandler(this.GameTypeButtons_CheckedChanged);
            // 
            // rbDinosaurs
            // 
            this.rbDinosaurs.AutoSize = true;
            this.rbDinosaurs.Font = new System.Drawing.Font("Arial", 9F);
            this.rbDinosaurs.Location = new System.Drawing.Point(92, 12);
            this.rbDinosaurs.Name = "rbDinosaurs";
            this.rbDinosaurs.Size = new System.Drawing.Size(83, 19);
            this.rbDinosaurs.TabIndex = 7;
            this.rbDinosaurs.TabStop = true;
            this.rbDinosaurs.Text = "Dinosaurs";
            this.rbDinosaurs.UseVisualStyleBackColor = true;
            this.rbDinosaurs.CheckedChanged += new System.EventHandler(this.GameTypeButtons_CheckedChanged);
            // 
            // rbUniverse
            // 
            this.rbUniverse.AutoSize = true;
            this.rbUniverse.Font = new System.Drawing.Font("Arial", 9F);
            this.rbUniverse.Location = new System.Drawing.Point(12, 12);
            this.rbUniverse.Name = "rbUniverse";
            this.rbUniverse.Size = new System.Drawing.Size(74, 19);
            this.rbUniverse.TabIndex = 6;
            this.rbUniverse.TabStop = true;
            this.rbUniverse.Text = "Universe";
            this.rbUniverse.UseVisualStyleBackColor = true;
            this.rbUniverse.CheckedChanged += new System.EventHandler(this.GameTypeButtons_CheckedChanged);
            // 
            // HighScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 202);
            this.Controls.Add(this.dgvUsersScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPornStars);
            this.Controls.Add(this.rbDinosaurs);
            this.Controls.Add(this.rbUniverse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HighScoresForm";
            this.Text = "High Scores Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsersScores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPornStars;
        private System.Windows.Forms.RadioButton rbDinosaurs;
        private System.Windows.Forms.RadioButton rbUniverse;
    }
}