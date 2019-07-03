namespace BrainyOgrasm
{
    partial class NewGameUserInput
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbCheckAge = new System.Windows.Forms.CheckBox();
            this.rbVisualStudio = new System.Windows.Forms.RadioButton();
            this.rbScientists = new System.Windows.Forms.RadioButton();
            this.rbUniverse = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbPlayerName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValidationText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnExit.Location = new System.Drawing.Point(145, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 34);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 10F);
            this.btnStart.Location = new System.Drawing.Point(15, 263);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 34);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbCheckAge
            // 
            this.cbCheckAge.AutoSize = true;
            this.cbCheckAge.Font = new System.Drawing.Font("Arial", 10F);
            this.cbCheckAge.Location = new System.Drawing.Point(17, 116);
            this.cbCheckAge.Name = "cbCheckAge";
            this.cbCheckAge.Size = new System.Drawing.Size(105, 20);
            this.cbCheckAge.TabIndex = 10;
            this.cbCheckAge.Text = "Programmer";
            this.cbCheckAge.UseVisualStyleBackColor = true;
            this.cbCheckAge.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbVisualStudio
            // 
            this.rbVisualStudio.AutoSize = true;
            this.rbVisualStudio.Font = new System.Drawing.Font("Arial", 10F);
            this.rbVisualStudio.Location = new System.Drawing.Point(16, 194);
            this.rbVisualStudio.Name = "rbVisualStudio";
            this.rbVisualStudio.Size = new System.Drawing.Size(104, 20);
            this.rbVisualStudio.TabIndex = 13;
            this.rbVisualStudio.TabStop = true;
            this.rbVisualStudio.Text = "VisualStudio";
            this.rbVisualStudio.UseVisualStyleBackColor = true;
            // 
            // rbScientists
            // 
            this.rbScientists.AutoSize = true;
            this.rbScientists.Font = new System.Drawing.Font("Arial", 10F);
            this.rbScientists.Location = new System.Drawing.Point(16, 168);
            this.rbScientists.Name = "rbScientists";
            this.rbScientists.Size = new System.Drawing.Size(86, 20);
            this.rbScientists.TabIndex = 12;
            this.rbScientists.TabStop = true;
            this.rbScientists.Text = "Scientists";
            this.rbScientists.UseVisualStyleBackColor = true;
            // 
            // rbUniverse
            // 
            this.rbUniverse.AutoSize = true;
            this.rbUniverse.Font = new System.Drawing.Font("Arial", 10F);
            this.rbUniverse.Location = new System.Drawing.Point(17, 142);
            this.rbUniverse.Name = "rbUniverse";
            this.rbUniverse.Size = new System.Drawing.Size(81, 20);
            this.rbUniverse.TabIndex = 11;
            this.rbUniverse.TabStop = true;
            this.rbUniverse.Text = "Universe";
            this.rbUniverse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Choose game mode :";
            // 
            // rtbPlayerName
            // 
            this.rtbPlayerName.Font = new System.Drawing.Font("Arial", 11F);
            this.rtbPlayerName.Location = new System.Drawing.Point(17, 40);
            this.rtbPlayerName.Multiline = false;
            this.rtbPlayerName.Name = "rtbPlayerName";
            this.rtbPlayerName.Size = new System.Drawing.Size(241, 26);
            this.rtbPlayerName.TabIndex = 9;
            this.rtbPlayerName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Player Name :";
            // 
            // lblValidationText
            // 
            this.lblValidationText.AutoSize = true;
            this.lblValidationText.Font = new System.Drawing.Font("Arial", 9.5F);
            this.lblValidationText.ForeColor = System.Drawing.Color.Red;
            this.lblValidationText.Location = new System.Drawing.Point(17, 221);
            this.lblValidationText.Name = "lblValidationText";
            this.lblValidationText.Size = new System.Drawing.Size(0, 16);
            this.lblValidationText.TabIndex = 18;
            // 
            // NewGameUserInput
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(271, 311);
            this.Controls.Add(this.lblValidationText);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbCheckAge);
            this.Controls.Add(this.rbVisualStudio);
            this.Controls.Add(this.rbScientists);
            this.Controls.Add(this.rbUniverse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbPlayerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NewGameUserInput";
            this.Text = "New Game ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbCheckAge;
        private System.Windows.Forms.RadioButton rbVisualStudio;
        private System.Windows.Forms.RadioButton rbScientists;
        private System.Windows.Forms.RadioButton rbUniverse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValidationText;
    }
}