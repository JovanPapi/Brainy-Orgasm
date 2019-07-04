namespace BrainyOgrasm
{
    partial class GameForm
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
            this.speedOfFallingObjects = new System.Windows.Forms.Timer(this.components);
            this.lblPoints = new System.Windows.Forms.Label();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            this.SuspendLayout();
            // 
            // speedOfFallingObjects
            // 
            this.speedOfFallingObjects.Enabled = true;
            this.speedOfFallingObjects.Interval = 250;
            this.speedOfFallingObjects.Tick += new System.EventHandler(this.speedOfFallingObjects_Tick);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(992, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(27, 29);
            this.lblPoints.TabIndex = 8;
            this.lblPoints.Text = "0";
            // 
            // life3
            // 
            this.life3.BackColor = System.Drawing.Color.Transparent;
            this.life3.Location = new System.Drawing.Point(167, 443);
            this.life3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(52, 32);
            this.life3.TabIndex = 7;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.BackColor = System.Drawing.Color.Transparent;
            this.life2.Location = new System.Drawing.Point(97, 443);
            this.life2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(52, 32);
            this.life2.TabIndex = 6;
            this.life2.TabStop = false;
            // 
            // life1
            // 
            this.life1.BackColor = System.Drawing.Color.Transparent;
            this.life1.Location = new System.Drawing.Point(28, 443);
            this.life1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(52, 32);
            this.life1.TabIndex = 5;
            this.life1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 526);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseMove);
            this.Resize += new System.EventHandler(this.GameForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer speedOfFallingObjects;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life1;
    }
}