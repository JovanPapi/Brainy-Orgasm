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
        private bool forceQuit;

        public GameForm(User player)
        {
            InitializeComponent();
            speedOfFallingObjects.Start();
            numOfTicks = 0;
            Game.HEIGHT_OF_FORM = Height;
            Game.WIDTH_OF_FORM = Width;
            ChooseGameMode(player);
            this.DoubleBuffered = true;
            life1.Image = life2.Image = life3.Image = new Bitmap(Properties.Resources.emoji, life1.Size);
            forceQuit = false;
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
            Lives();
            lblPoints.ForeColor = scene.ColorOfPoints;
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
            if (scene.Move())
            {
                Invalidate(true);
                EndGame();
                return;
            }

            try
            {
                scene.CheckCollision();
            }
            catch (ShowContentException)
            {
                ShowContent();
            }     
            Invalidate(true);
        }

        private void EndGame()
        {
            speedOfFallingObjects.Stop();
            if (!forceQuit)
            {
                MessageBox.Show("Game ended. You've scored " + scene.Player.Points + " points!");
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scene.MovePlayer(e.Location);
            try
            {
                scene.CheckCollision();
            }
            catch (ShowContentException)
            {
                ShowContent();  
            }
            Invalidate(true);
        }

        private void ShowContent()
        {
            speedOfFallingObjects.Stop();
            Invalidate(true);
            ContentForm cf = new ContentForm(scene.ChooseContent());
            cf.ShowDialog();
            if (scene.Update())
            {
                Invalidate(true);
                EndGame();
                return;
            }
            speedOfFallingObjects.Start();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            forceQuit = true;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (speedOfFallingObjects.Enabled)
                {
                    speedOfFallingObjects.Stop();
                    this.MouseMove -= Form1_MouseMove;
                }
                else
                {
                    speedOfFallingObjects.Start();
                    this.MouseMove += Form1_MouseMove;
                }
            }
        }
    }
}
