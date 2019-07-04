using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    public abstract class Game
    {
        private List<FallingObject> fallingObjects;
        protected List<Bitmap> pictures;

        public User Player { get; set; }
        public Bitmap BackgroundImage { get; set; }
        public int Speed { get; set; }

        public static int WIDTH_OF_FORM;
        public static int HEIGHT_OF_FORM;

        public static Size SIZE_OF_FALLING_OBJECT = new Size(50, 50);
        public static Size SIZE_OF_COLLECTOR = new Size(100, 100);
        public static Size SIZE_OF_BACKGROUND_IMAGE;

        public static Random r = new Random();

        public Color ColorOfPoints { get; set; }

        public Game(User player)
        {
            Player = player;
            Player.Collector = new Collector();
            fallingObjects = new List<FallingObject>();
            pictures = new List<Bitmap>();
            Speed = 50;
            SIZE_OF_BACKGROUND_IMAGE = new Size(WIDTH_OF_FORM, HEIGHT_OF_FORM);
        }

        public void AddFallingObject()
        {
            Point defaultLocation = new Point(r.Next(0, WIDTH_OF_FORM - 70), 0);
            fallingObjects.Add(new FallingObject(pictures[0], defaultLocation));
        }

        public void Draw(Graphics g)
        {
            Player.Draw(g);
            foreach (FallingObject fo in fallingObjects)
                fo.Draw(g);
        }

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

        public void MovePlayer(Point newLocation)
        {
            Player.Move(newLocation);
        }

        public void CheckCollision()
        {
            for (int i = 0; i < fallingObjects.Count; i++)
            {
                if (fallingObjects[i].Collide(Player.Collector.RectangleOfCollector))
                {
                    fallingObjects.RemoveAt(i);
                    i--;
                    Player.Points++;
                    if (Player.Points % 10 == 0)
                    {
                        throw new ShowContentException();
                    }
                }
            }
        }

        public bool Update()
        {
            pictures.RemoveAt(0);
            if (ChangeOthers())
                return true;
            if (Player.Points % 30 == 0)
                Speed -= 10;
            return false;
        }

        private bool ChangeOthers()
        {
            foreach (FallingObject fo in fallingObjects)
            {
                try
                {
                    fo.Image = pictures[0];
                }
                catch (Exception)
                {
                    return true;
                }
            }
            return false;
        }

        protected void InitializeCollector()
        {
            Player.Collector.RectangleOfCollector = new Rectangle(Player.Collector.Location.X - Game.SIZE_OF_COLLECTOR.Width / 2 + 20,
                Player.Collector.Location.Y - Game.SIZE_OF_COLLECTOR.Height / 2 + 35,
                Player.Collector.Image.Size.Width - 35, Player.Collector.Image.Size.Height);
        }

        public void Clear()
        {
            
        }

        protected abstract void FillPictureList();
        public abstract Content ChooseContent();

        
    }
}
