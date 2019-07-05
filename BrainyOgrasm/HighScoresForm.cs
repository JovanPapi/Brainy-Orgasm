using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BrainyOgrasm
{
    /// <summary>
    /// Form for displaying the high scores made in every Mode
    /// </summary>
    public partial class HighScoresForm : Form
    {
        private List<User> secondaryUsers; // contains the users from the current mode that is displaying
        public HighScoresForm()
        {
            InitializeComponent();
            secondaryUsers = new List<User>();
            this.MaximizeBox = false;
            dgvUsersScores.ReadOnly = true;
            dgvUsersScores.ScrollBars = ScrollBars.None;
            dgvUsersScores.ClearSelection();
        }

        private void GameTypeButtons_CheckedChanged(object sender, EventArgs e)
        {
            secondaryUsers.Clear();
            
            // which Mode should be displayed
            if (rbUniverse.Checked) 
            {
                foreach (User us in MainForm.users)
                {
                    if (us.TypeOfGame == Mode.Universe)
                    {
                        secondaryUsers.Add(us);
                    }
                }
            }
            else if (rbScientists.Checked)
            {
                foreach (User us in MainForm.users)
                {
                    if (us.TypeOfGame == Mode.Scientists)
                        secondaryUsers.Add(us);
                }
            }
            else if (rbVisualStudio.Checked)
            {
                foreach (User us in MainForm.users)
                {
                    if (us.TypeOfGame == Mode.VisualStudio)
                        secondaryUsers.Add(us);
                }
            }

            secondaryUsers.Sort(); // sort by the users points
            dgvUsersScores.DataSource = null;
            dgvUsersScores.DataSource = secondaryUsers;
            dgvUsersScores.Height = (dgvUsersScores.Rows.Count + 2) * dgvUsersScores.RowTemplate.Height;
            this.Height = dgvUsersScores.Height + 80;
            dgvUsersScores.Columns.Remove("TypeOfGame");
            dgvUsersScores.Columns.Remove("LivesLeft");
            dgvUsersScores.Columns.Remove("Collector");
        }

        private void dgvUsersScores_Resize(object sender, EventArgs e)
        {
            if (dgvUsersScores.Height + 150 > this.Height)
                this.Height = dgvUsersScores.Height;
        }
    }
}
