using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    [Serializable]
    public class Collector
    {
        private int maxX, maxY;
        private int minX, minY;

        public Point Location { get; set; }
        public Rectangle Rectangle { get; set; }
        public Bitmap Image { get; set; }

        public Collector()
        {
            minY = Game.HEIGHT_OF_FORM - 100;
            maxY = Game.HEIGHT_OF_FORM - 85;
            minX = 40;
            maxX = Game.WIDTH_OF_FORM - 70;
            Location = new Point(Game.WIDTH_OF_FORM / 2, minY);
        }

        public void Draw(Graphics g)
        {
            g.DrawImageUnscaled(Image, Location.X - Game.SIZE_OF_COLLECTOR.Width / 2,
                Location.Y - Game.SIZE_OF_COLLECTOR.Height / 2,
                Game.SIZE_OF_COLLECTOR.Width, Game.SIZE_OF_COLLECTOR.Height);
        }

        public void Move(Point newLocation)
        {
            int x = 0, y = 0;
 
            if (newLocation.X <= minX)
                x = minX;
            else if (newLocation.X >= maxX)
                x = maxX;
            else
                x = newLocation.X;

            if (newLocation.Y <= minY)
                y = minY;
            else if (newLocation.Y >= maxY)
                y = maxY;
            else
                y = newLocation.Y;

            Location = new Point(x, y);
            Rectangle = new Rectangle(Location.X - Game.SIZE_OF_COLLECTOR.Width / 2 + 20,
                Location.Y - Game.SIZE_OF_COLLECTOR.Height / 2 + 35, Image.Size.Width - 35, Image.Size.Height);
        }
    }
}
