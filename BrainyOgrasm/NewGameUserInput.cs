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
            rbVisualStudio.Visible = false;
            this.MaximizeBox = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            rbVisualStudio.Checked = false;
            if (cbCheckAge.Checked)
                rbVisualStudio.Visible = true;
            else
                rbVisualStudio.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                user = new User(rtbPlayerName.Text, TypeOfGame());
                if (MainForm.users.Contains(user))
                {
                    MessageBox.Show("The username " + user.Name + " is taken!");
                    rtbPlayerName.Focus();
                    return;
                }
                this.Visible = false;
                GameForm gf = new GameForm(user);
                gf.ShowDialog();
                this.Visible = true;
                if (gf.DialogResult != DialogResult.Cancel)
                {
                    MainForm.users.Add(user);
                }
                DialogResult = DialogResult.Cancel;
            }
            else
                return;
        }

        // Method that performs validation over controls of the form 
        private bool Validation()
        {
            if (rtbPlayerName.Text == "" && !rbVisualStudio.Checked
                && !rbUniverse.Checked && !rbScientists.Checked)
            {
                lblValidationText.Text = "Enter your player name and select\na game type to continue.";
                return false;
            }
            else if (rtbPlayerName.Text != "" && (!rbVisualStudio.Checked
                && !rbUniverse.Checked && !rbScientists.Checked))
            {
                lblValidationText.Text = "Select a game type to continue.";
                return false;
            }
            else if (rtbPlayerName.Text == "" && (rbVisualStudio.Checked
                || rbUniverse.Checked || rbScientists.Checked))
            {
                lblValidationText.Text = "Enter your player name to continue.";
                return false;
            }

            return true;
        }

        // Method that returns Mode enum type for the mode that the user picked
        private Mode TypeOfGame()
        {
            if (rbScientists.Checked)
                return Mode.Scientists;
            else if (rbVisualStudio.Checked)
                return Mode.VisualStudio;
            return Mode.Universe;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
