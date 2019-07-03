namespace BrainyOgrasm
{
    partial class ContentForm
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
            this.txtMainContent = new System.Windows.Forms.TextBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblSubDomainTitle = new System.Windows.Forms.Label();
            this.pbOther = new System.Windows.Forms.PictureBox();
            this.pbFalling = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalling)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMainContent
            // 
            this.txtMainContent.Enabled = false;
            this.txtMainContent.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Italic);
            this.txtMainContent.Location = new System.Drawing.Point(12, 162);
            this.txtMainContent.Multiline = true;
            this.txtMainContent.Name = "txtMainContent";
            this.txtMainContent.Size = new System.Drawing.Size(305, 473);
            this.txtMainContent.TabIndex = 0;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainTitle.Location = new System.Drawing.Point(12, 23);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(584, 74);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "[MainTitle]";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubDomainTitle
            // 
            this.lblSubDomainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubDomainTitle.Location = new System.Drawing.Point(358, 110);
            this.lblSubDomainTitle.Name = "lblSubDomainTitle";
            this.lblSubDomainTitle.Size = new System.Drawing.Size(225, 48);
            this.lblSubDomainTitle.TabIndex = 2;
            this.lblSubDomainTitle.Text = "[SubDomainTitle]";
            this.lblSubDomainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbOther
            // 
            this.pbOther.Location = new System.Drawing.Point(358, 199);
            this.pbOther.Name = "pbOther";
            this.pbOther.Size = new System.Drawing.Size(225, 179);
            this.pbOther.TabIndex = 3;
            this.pbOther.TabStop = false;
            // 
            // pbFalling
            // 
            this.pbFalling.Location = new System.Drawing.Point(384, 433);
            this.pbFalling.Name = "pbFalling";
            this.pbFalling.Size = new System.Drawing.Size(169, 138);
            this.pbFalling.TabIndex = 4;
            this.pbFalling.TabStop = false;
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 656);
            this.Controls.Add(this.pbFalling);
            this.Controls.Add(this.pbOther);
            this.Controls.Add(this.lblSubDomainTitle);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.txtMainContent);
            this.Name = "ContentForm";
            this.Text = "ContentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMainContent;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblSubDomainTitle;
        private System.Windows.Forms.PictureBox pbOther;
        private System.Windows.Forms.PictureBox pbFalling;
    }
}