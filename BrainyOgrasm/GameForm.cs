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
    public partial class GameForm : Form
    {
        private Game scene;
        private int numOfTicks;

        public GameForm(User player)
        {
            InitializeComponent();
            numOfTicks = 0;
            Game.HEIGHT_OF_FORM = Height;
            Game.WIDTH_OF_FORM = Width;
            ChooseGameMode(player);
            this.DoubleBuffered = true;
            life1.Image = life2.Image = life3.Image = new Bitmap(Properties.Resources.emoji, life1.Size);
        }

        private void ChooseGameMode(User player)
        {
            switch (player.TypeOfGame)
            {
                case Mode.Scientists:
                    scene = new ScientistsGame(player);
                    break;
                case Mode.Universe:
                    scene = new UniverseGame(player);
                    break;
                case Mode.VisualStudio:
                    scene = new VSGame(player);
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
            speedOfFallingObjects.Interval = scene.Speed;
            this.BackgroundImage = scene.BackgroundImage;
            this.Text = scene.Player.TypeOfGame.ToString();
            lblPoints.Text = scene.Player.Points.ToString();
            lblPoints.ForeColor = scene.ColorOfPoints;
            //Lives();
        }

        private void Lives()
        {
            if (scene.Player.LivesLeft == 2)
                life3.Visible = false;
            if (scene.Player.LivesLeft == 1)
                life2.Visible = false;
            if (scene.Player.LivesLeft == 0)
                life1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (numOfTicks % 8 == 0)
            {
                scene.AddFallingObject();
            }
            numOfTicks++;
            if (scene.Move() || scene.CheckCollision())
            {
                EndGame();
                return;
            }
            Invalidate(true);
        }

        private void EndGame()
        {
            DialogResult = DialogResult.OK;
            speedOfFallingObjects.Stop();
            MessageBox.Show("Game ended. You've scored " + scene.Player.Points + " points!");
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scene.MovePlayer(e.Location);
            if (scene.CheckCollision())
                EndGame();
            Invalidate(true);
        }
    }
}
