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
                " the collector for collecting the items." + "The player has three lives" +
                " and by missing an item he loses one life. If he misses three items, the players game is over.";
            tbGameRule.Select(0, 0);

            tbGameModes.Text =
                "1. Universe ---> In this game mode the objects represent bizzare yet beautiful and breathtaking things" +
                " that dwell in the universe from the begging of time till now. On every ten points collected" +
                " a message box will pop-up that shares additional info about the subject." +
                "\r\n\r\n2. Scientists ---> In this game mode the objects represents world famous Scientists" +
                " that changed our world with their inventions." +
                "\r\n\r\n3. Visual Studio ---> Play this mode to learn about new types of" +
                " programming languages and a additional information about them!";
            tbGameModes.Select(0, 0);
            tbGameModes.ReadOnly = true;
            tbGameModes.BackColor = Color.LightGray;

            lblDev.Text = "Developed by :" +
                "\r\nJovan Papalazoski " +
                "\r\nMihail Papalazoski " +
                "\r\nDejan Slamkov ";
            
            
            
        }
    }
}
