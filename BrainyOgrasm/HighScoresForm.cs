using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainyOgrasm
{
    public partial class HighScoresForm : Form
    {
        private List<Users> secondaryUsers;
        public HighScoresForm()
        {
            InitializeComponent();
            secondaryUsers = new List<Users>();
            this.MaximizeBox = false;
            dgvUsersScores.ReadOnly = true;
            dgvUsersScores.ScrollBars = ScrollBars.None;

        }

        private void GameTypeButtons_CheckedChanged(object sender, EventArgs e)
        {
            secondaryUsers.Clear();

            if (rbUniverse.Checked)
            {
                foreach (Users us in MainForm.users)
                {
                    if (us.TypeOfGame.Equals("Universe"))
                    {
                        secondaryUsers.Add(us);
                    }
                }
            }
            else if (rbDinosaurs.Checked)
            {
                foreach (Users us in MainForm.users)
                {
                    if (us.TypeOfGame.Equals("Dinosaurs"))
                        secondaryUsers.Add(us);
                }
            }
            else if (rbPornStars.Checked)
            {
                foreach (Users us in MainForm.users)
                {
                    if (us.TypeOfGame.Equals("Porn Stars"))
                        secondaryUsers.Add(us);
                }
            }

            dgvUsersScores.DataSource = null;
            dgvUsersScores.DataSource = secondaryUsers;
            dgvUsersScores.Columns.Remove("TypeOfGame");
            dgvUsersScores.Columns.Remove("LivesLeft");
            this.Height = dgvUsersScores.ColumnHeadersHeight * dgvUsersScores.Rows.Count + 125;
            dgvUsersScores.Height = dgvUsersScores.ColumnHeadersHeight * dgvUsersScores.Rows.Count + 27;
        }
    }
}
