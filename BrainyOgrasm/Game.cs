using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    /// <summary>
    /// Abstract class for coordinating the GameForm
    /// </summary>
    public abstract class Game
    {
        // list that contains the falling objects that are currently on the GameForm
        private List<FallingObject> fallingObjects;
        // queue of images that are correlated with the current Mode, that will represent the falling objects
        protected Queue<Bitmap> pictures;
        // queue of Content objects that are correlated with the current Mode
        protected Queue<Content> contents;

        /// <summary>
        /// Gets or sets the current User
        /// </summary>
        public User Player { get; set; }
        /// <summary>
        /// Gets or sets the background image of the GameForm for the current Mode
        /// </summary>
        public Bitmap BackgroundImage { get; set; }
        /// <summary>
        /// Gets or sets the speed of the Falling Objects
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// Gets or sets the Color that the points of the Player will be displayed
        /// </summary>
        public Color ColorOfPoints { get; set; } // every mode has different backgrounds which requires different color for the points

        /// <summary>
        /// Current width of the GameForm
        /// </summary>
        public static int WIDTH_OF_FORM;
        /// <summary>
        /// Current height of the GameForm
        /// </summary>
        public static int HEIGHT_OF_FORM;

        /// <summary>
        /// The size of the Falling Objects
        /// </summary>
        public static Size SIZE_OF_FALLING_OBJECT = new Size(50, 50);
        /// <summary>
        /// The size of the Collector 
        /// </summary>
        public static Size SIZE_OF_COLLECTOR = new Size(100, 100);
        /// <summary>
        /// The size of the Background image of the GameForm
        /// </summary>
        public static Size SIZE_OF_BACKGROUND_IMAGE;

        public static Random r = new Random();

        /// <summary>
        /// Constructor for Game class
        /// </summary>
        /// <param name="player">The User that started the game</param>
        public Game(User player)
        {
            Player = player;
            Player.Collector = new Collector();
            fallingObjects = new List<FallingObject>();
            pictures = new Queue<Bitmap>();
            contents = new Queue<Content>();
            Speed = 50;
            SIZE_OF_BACKGROUND_IMAGE = new Size(WIDTH_OF_FORM, HEIGHT_OF_FORM);
            Content.MAIN_TITLE = Player.TypeOfGame == Mode.VisualStudio ? "Visual Studio" : Player.TypeOfGame.ToString();
        }

        /// <summary>
        /// Adds a Falling Object to the game on a random position
        /// </summary>
        public void AddFallingObject()
        {
            Point defaultLocation = new Point(r.Next(0, WIDTH_OF_FORM - 70), 0);
            fallingObjects.Add(new FallingObject(pictures.Peek(), defaultLocation));
        }

        /// <summary>
        /// Draws the Falling Objects and the Collector
        /// </summary>
        /// <param name="g">Graphics object</param>
        public void Draw(Graphics g)
        {
            Player.Draw(g);
            foreach (FallingObject fo in fallingObjects)
                fo.Draw(g);
        }

        /// <summary>
        /// Moves the Falling Objects
        /// </summary>
        /// <returns>True if the player has no lives left</returns>
        public bool Move()
        {
            for (int i = 0; i < fallingObjects.Count; i++)
            {
                if (fallingObjects[i].Move())
                {
                    fallingObjects.RemoveAt(i);
                    i--;
                    Player.LivesLeft--;
                    if (Player.CheckLives())
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Moves the player's collector
        /// </summary>
        /// <param name="newLocation">The new location of the player</param>
        public void MovePlayer(Point newLocation)
        {
            Player.Move(newLocation);
        }

        /// <summary>
        /// Checks every falling object for collision with the Collector 
        /// </summary>
        /// <exception cref="ShowContentException">
        /// Thrown when there is a need for ContentForm (every 20 points)
        /// </exception>
        public void CheckCollision()
        {
            for (int i = 0; i < fallingObjects.Count; i++)
            {
                if (fallingObjects[i].Collide(Player.Collector.Rectangle) && !fallingObjects[i].Invincible)
                {
                    fallingObjects.RemoveAt(i);
                    i--;
                    Player.Points++;
                    if (Player.Points % 20 == 0)
                    {
                        fallingObjects.Clear();
                        throw new ShowContentException();
                    }
                }
            }
        }

        /// <summary>
        /// Transitions to the next topic (changes image for falling object)
        /// </summary>
        /// <returns>
        /// True, if the game has reached its end (no topics left)
        /// </returns>
        public bool Update()
        {
            pictures.Dequeue();
            if (pictures.Count == 0)
                return true;
            if (Player.Points % 40 == 0)
                Speed -= 10;
            return false;
        }

        /// <summary>
        /// Initializes the collector after the initializing of the User
        /// </summary>
        protected void InitializeCollector()
        {
            Player.Collector.Rectangle = new Rectangle(Player.Collector.Location.X - Game.SIZE_OF_COLLECTOR.Width / 2 + Collector.PADDING_X,
                Player.Collector.Location.Y - Game.SIZE_OF_COLLECTOR.Height / 2 + Collector.PADDING_Y,
                Player.Collector.Image.Size.Width - Collector.PADDING_WIDTH, Player.Collector.Image.Size.Height);
        }

        /// <summary>
        /// Removes all the Falling Objects that are not in the bounds of the new size
        /// of the GameForm when the form is resizing 
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i < fallingObjects.Count; i++)
            {
                if (fallingObjects[i].IsOutOfBounds())
                {
                    fallingObjects.RemoveAt(i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Chooses the Content for the current topic of the current Mode
        /// </summary>
        /// <returns>Content object that containg all the info for the current topic of the current Mode</returns>
        public Content ChooseContent()
        {
            return contents.Dequeue();
        }
        
        /// <summary>
        /// Chooses the images for the current Mode
        /// </summary>
        protected abstract void FillPicturesQueue();
        /// <summary>
        /// Chooses the content for the current Mode
        /// </summary>
        protected abstract void FillPaths();
    }
}
