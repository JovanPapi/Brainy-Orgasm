﻿namespace BrainyOgrasm
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
            this.lblContent = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGameModes
            // 
            this.tbGameModes.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGameModes.Location = new System.Drawing.Point(12, 294);
            this.tbGameModes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGameModes.Multiline = true;
            this.tbGameModes.Name = "tbGameModes";
            this.tbGameModes.ReadOnly = true;
            this.tbGameModes.Size = new System.Drawing.Size(556, 281);
            this.tbGameModes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.label2.Location = new System.Drawing.Point(16, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game Modes";
            // 
            // tbGameRule
            // 
            this.tbGameRule.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGameRule.Location = new System.Drawing.Point(12, 52);
            this.tbGameRule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGameRule.Multiline = true;
            this.tbGameRule.Name = "tbGameRule";
            this.tbGameRule.ReadOnly = true;
            this.tbGameRule.Size = new System.Drawing.Size(556, 197);
            this.tbGameRule.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Rules";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Blackadder ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(209, 556);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(0, 34);
            this.lblContent.TabIndex = 7;
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.Location = new System.Drawing.Point(8, 579);
            this.lblDev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(59, 24);
            this.lblDev.TabIndex = 8;
            this.lblDev.Text = "label3";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(444, 626);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(124, 38);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // HowToPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 677);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.tbGameModes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGameRule);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HowToPlayForm";
            this.Text = "How To Play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGameModes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGameRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Button btnOk;
    }
}