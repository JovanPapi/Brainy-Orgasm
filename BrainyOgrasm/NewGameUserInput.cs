using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainyOgrasm
{
    public partial class NewGameUserInput : Form
    {
        public User user;
        public NewGameUserInput()
        {
            InitializeComponent();
            rbPornStars.Visible = false;
            this.MaximizeBox = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            rbPornStars.Checked = false;
            if (cbCheckAge.Checked)
                rbPornStars.Visible = true;
            else
                rbPornStars.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                user = new User(rtbPlayerName.Text, TypeOfGame());
                DialogResult = DialogResult.OK;

            }
            else
                return;
        }
        public bool Validation()
        {
            if (rtbPlayerName.Text == "" && !rbPornStars.Checked
                && !rbUniverse.Checked && !rbDinosaurs.Checked)
            {
                lblValidationText.Text = "Enter your player name and select\na game type to continue.";
                return false;
            }
            else if (rtbPlayerName.Text != "" && (!rbPornStars.Checked
                && !rbUniverse.Checked && !rbDinosaurs.Checked))
            {
                lblValidationText.Text = "Select a game type to continue.";
                return false;
            }
            else if (rtbPlayerName.Text == "" && (rbPornStars.Checked
                || rbUniverse.Checked || rbDinosaurs.Checked))
            {
                lblValidationText.Text = "Enter your player name to continue.";
                return false;
            }

            return true;
        }
        private string TypeOfGame()
        {
            if (rbDinosaurs.Checked)
                return rbDinosaurs.Text;
            else if (rbPornStars.Checked)
                return rbPornStars.Text;
            else if (rbUniverse.Checked)
                return rbUniverse.Text;
            return null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
