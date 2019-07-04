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
            UpdateDataResize();
            this.DoubleBuffered = true;
            forceQuit = false;
            this.BackgroundImage = scene.BackgroundImage;
            this.Text = scene.Player.TypeOfGame == Mode.VisualStudio ? "Visual Studio" : scene.Player.TypeOfGame.ToString();
            lblPoints.ForeColor = scene.ColorOfPoints;
        }

        private void UpdateDataResize()
        {
            life1.Image = life2.Image = life3.Image = new Bitmap(Properties.Resources.emoji, life1.Size);
            int bottom = this.Height - 75;
            life1.Location = new Point(20, bottom);
            life2.Location = new Point(life1.Location.X + life1.Width + 16, bottom);
            life3.Location = new Point(life2.Location.X + life1.Width + 16, bottom);
            Game.HEIGHT_OF_FORM = Height;
            Game.WIDTH_OF_FORM = Width;
            Game.SIZE_OF_BACKGROUND_IMAGE = new Size(Width, Height);
            scene.Player.Collector.UpdateDataResize();
            scene.BackgroundImage = new Bitmap(scene.BackgroundImage, Game.SIZE_OF_BACKGROUND_IMAGE);
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

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
            speedOfFallingObjects.Interval = scene.Speed;
            lblPoints.Text = scene.Player.Points.ToString();
            Lives();
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

        private void speedOfFallingObjects_Tick(object sender, EventArgs e)
        {
            if (numOfTicks % 10 == 0)
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
                if(scene.Player.Points < 200)
                    MessageBox.Show("Game ended. You've scored " + scene.Player.Points + " points!");
                else
                    MessageBox.Show("Congratulations, you've finished this mode. You made 200 points!");
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
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
            this.Visible = false;
            ContentForm cf = new ContentForm(scene.ChooseContent());
            cf.ShowDialog();
            this.Visible = true;

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
                    this.MouseMove -= GameForm_MouseMove;
                }
                else
                {
                    speedOfFallingObjects.Start();
                    this.MouseMove += GameForm_MouseMove;
                }
            }
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            if(this.Width < Game.WIDTH_OF_FORM || this.Height < Game.HEIGHT_OF_FORM)
            {

                if (scene != null)
                {
                    UpdateDataResize();
                    this.BackgroundImage = new Bitmap(scene.BackgroundImage, Game.SIZE_OF_BACKGROUND_IMAGE);
                    scene.Clear();
                }
            }
            if (scene != null)
            {
                UpdateDataResize();
                this.BackgroundImage = new Bitmap(scene.BackgroundImage, Game.SIZE_OF_BACKGROUND_IMAGE);
            }
        }
    }
}
