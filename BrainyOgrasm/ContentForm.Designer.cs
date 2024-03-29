﻿namespace BrainyOgrasm
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblSubDomainTitle = new System.Windows.Forms.Label();
            this.pbOther = new System.Windows.Forms.PictureBox();
            this.pbFalling = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtMainContent = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalling)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainTitle.Location = new System.Drawing.Point(19, 22);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(584, 74);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "[MainTitle]";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubDomainTitle
            // 
            this.lblSubDomainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubDomainTitle.Location = new System.Drawing.Point(325, 96);
            this.lblSubDomainTitle.Name = "lblSubDomainTitle";
            this.lblSubDomainTitle.Size = new System.Drawing.Size(277, 48);
            this.lblSubDomainTitle.TabIndex = 2;
            this.lblSubDomainTitle.Text = "[SubDomainTitle]";
            this.lblSubDomainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbOther
            // 
            this.pbOther.Location = new System.Drawing.Point(352, 160);
            this.pbOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbOther.Name = "pbOther";
            this.pbOther.Size = new System.Drawing.Size(225, 178);
            this.pbOther.TabIndex = 3;
            this.pbOther.TabStop = false;
            // 
            // pbFalling
            // 
            this.pbFalling.Location = new System.Drawing.Point(325, 372);
            this.pbFalling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFalling.Name = "pbFalling";
            this.pbFalling.Size = new System.Drawing.Size(277, 217);
            this.pbFalling.TabIndex = 4;
            this.pbFalling.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(471, 594);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 41);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMainContent
            // 
            this.txtMainContent.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Italic);
            this.txtMainContent.Location = new System.Drawing.Point(12, 160);
            this.txtMainContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMainContent.Name = "txtMainContent";
            this.txtMainContent.ReadOnly = true;
            this.txtMainContent.Size = new System.Drawing.Size(305, 473);
            this.txtMainContent.TabIndex = 6;
            this.txtMainContent.Text = "";
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 650);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbFalling);
            this.Controls.Add(this.pbOther);
            this.Controls.Add(this.lblSubDomainTitle);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.txtMainContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ContentForm";
            this.Text = "Content";
            ((System.ComponentModel.ISupportInitialize)(this.pbOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblSubDomainTitle;
        private System.Windows.Forms.PictureBox pbOther;
        private System.Windows.Forms.PictureBox pbFalling;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox txtMainContent;
    }
}