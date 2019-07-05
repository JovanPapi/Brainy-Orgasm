using System;
using System.Windows.Forms;

namespace BrainyOgrasm
{
    /// <summary>
    /// Form that displayes when the user wants to start a new game
    /// </summary>
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

        /// <summary>
        /// Performs validation on the controls
        /// </summary>
        /// <returns>True, if every control is validated</returns>
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

        /// <summary>
        /// Checks the radio buttons for the chosen game
        /// </summary>
        /// <returns>Mode enum representing the Mode the User choose</returns>
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
