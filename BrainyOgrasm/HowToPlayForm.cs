using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrainyOgrasm
{
    /// <summary>
    /// Form for displaying the rules of the game
    /// </summary>
    public partial class HowToPlayForm : Form
    {
        public HowToPlayForm()
        {
            this.MaximizeBox = false;
            InitializeComponent();

            tbGameRule.BackColor = Color.LightGray;
            tbGameRule.BorderStyle = BorderStyle.Fixed3D;
            tbGameRule.ReadOnly = true;

            tbGameRule.Text = "In this game, the player's objective is to collect \nas many " +
                "objects as possible as they appear from the top of the screen." +
                " On the bottom of the screen is a collector which the player is moving with the mouse and use" +
                " the collector for collecting the items." + "The player can pause the game by pressing the space bar." +
                "The player has three lives" +
                " and by missing an item he loses one life. If he misses three items, the players game is over." + 
                "You can also play in fullscreen mode.";
            tbGameRule.Select(0, 0);

            tbGameModes.Text =
                "1. Universe ---> In this game mode the objects represent bizzare yet beautiful and breathtaking things" +
                " that dwell in the universe from the beggining of time till now. On every 20 points collected" +
                " a message box will pop-up that shares additional info about the subject." +
                "\r\n\r\n2. Scientists ---> In this game mode the objects represents world famous Scientists" +
                " that changed our world with their inventions." +
                "\r\n\r\n3. Visual Studio ---> Play this mode to learn which" +
                " programming languages are supported by Visual Studio and additional information about them!";
            tbGameModes.Select(0, 0);
            tbGameModes.ReadOnly = true;
            tbGameModes.BackColor = Color.LightGray;

            lblDev.Text = "Developed by :" +
                "\r\nJovan Papalazoski " +
                "\r\nMihail Papalazoski " +
                "\r\nDejan Slamkov ";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
