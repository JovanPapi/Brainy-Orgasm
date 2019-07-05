using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrainyOgrasm
{
    /// <summary>
    /// Form that displays the contents of the Game object 
    /// </summary>
    public partial class GameForm : Form
    {
        private Game scene;
        private int numOfTicks;
        private bool forceQuit;

        /// <summary>
        /// Contructor for GameForm
        /// </summary>
        /// <param name="player">The User that is currently playing</param>
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
            // if the player closes the form with clicking the X button on the form, the User is not stored (his score)
            forceQuit = false; 
            this.BackgroundImage = scene.BackgroundImage;
            this.Text = scene.Player.TypeOfGame == Mode.VisualStudio ? "Visual Studio" : scene.Player.TypeOfGame.ToString();
            lblPoints.ForeColor = scene.ColorOfPoints;
            life1.Image = life2.Image = life3.Image = new Bitmap(Properties.Resources.emoji, life1.Size);
        }

        /// <summary>
        /// Updates the info that is being affected by the resize of the GameForm
        /// </summary>
        private void UpdateDataResize()
        {
            int bottom = this.Height - 75;
            // the location of the life images
            life1.Location = new Point(20, bottom);
            life2.Location = new Point(life1.Location.X + life1.Width + 16, bottom);
            life3.Location = new Point(life2.Location.X + life1.Width + 16, bottom);
            // the height and width that i'm storing in the Game class
            Game.HEIGHT_OF_FORM = Height;
            Game.WIDTH_OF_FORM = Width;
            Game.SIZE_OF_BACKGROUND_IMAGE = new Size(Width, Height);
            scene.Player.Collector.UpdateDataResize();
            scene.BackgroundImage = new Bitmap(scene.BackgroundImage, Game.SIZE_OF_BACKGROUND_IMAGE);
            // the location of the label for points
            lblPoints.Location = new Point(Game.WIDTH_OF_FORM - 73, 15);
        }

        /// <summary>
        /// Chooses the concrete class for the Game reference
        /// </summary>
        /// <param name="player">The User that is currently playing</param>
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

        /// <summary>
        /// Checks the lives of the User and shows the images for lives accordingly
        /// </summary>
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
            if (numOfTicks % 10 == 0) // adds a Falling object every 10 ticks
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

        /// <summary>
        /// Closes the GameForm
        /// </summary>
        private void EndGame()
        {
            speedOfFallingObjects.Stop();
            if (!forceQuit) // if the GameForm wasn't closed by clicking the X button
            {
                if(scene.Player.Points < 200)
                    MessageBox.Show("Game ended. You've scored " + scene.Player.Points + " points!");
                else
                    MessageBox.Show("Congratulations, you've finished this mode. You made 200 points!");
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Cancel; // this indicates that User should not be stored (forceQuit == true)
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

        /// <summary>
        /// Displays the ContentForm for the current topic
        /// </summary>
        private void ShowContent()
        {
            speedOfFallingObjects.Stop();
            Invalidate(true);
            this.Visible = false; // the GameForm is not visible during the showing of the ContentForm
            ContentForm cf = new ContentForm(scene.ChooseContent());
            cf.ShowDialog();
            this.Visible = true;

            if (scene.Update())
            {
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
            if (scene != null)
            {
                if (this.Width < Game.WIDTH_OF_FORM || this.Height < Game.HEIGHT_OF_FORM)
                {
                    // if the new Size of the GameForm is smaller than the previous one
                    // some of the falling objects may need to be cleared
                    UpdateDataResize();
                    this.BackgroundImage = new Bitmap(scene.BackgroundImage, Game.SIZE_OF_BACKGROUND_IMAGE);
                    scene.Clear();
                }
                else
                {
                    UpdateDataResize();
                    this.BackgroundImage = new Bitmap(scene.BackgroundImage, Game.SIZE_OF_BACKGROUND_IMAGE);
                }
            }
        }
    }
}
