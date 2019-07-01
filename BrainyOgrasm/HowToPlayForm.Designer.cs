namespace BrainyOgrasm
{
    partial class HowToPlayForm
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
            this.tbGameModes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGameRule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGameModes
            // 
            this.tbGameModes.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGameModes.Location = new System.Drawing.Point(9, 220);
            this.tbGameModes.Multiline = true;
            this.tbGameModes.Name = "tbGameModes";
            this.tbGameModes.Size = new System.Drawing.Size(418, 229);
            this.tbGameModes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game Modes";
            // 
            // tbGameRule
            // 
            this.tbGameRule.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGameRule.Location = new System.Drawing.Point(9, 42);
            this.tbGameRule.Multiline = true;
            this.tbGameRule.Name = "tbGameRule";
            this.tbGameRule.Size = new System.Drawing.Size(418, 117);
            this.tbGameRule.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Rules";
            // 
            // HowToPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 457);
            this.Controls.Add(this.tbGameModes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGameRule);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HowToPlayForm";
            this.Text = "How To Play Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGameModes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGameRule;
        private System.Windows.Forms.Label label1;
    }
}