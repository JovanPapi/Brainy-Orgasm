using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    /// <summary>
    /// Class that represents the object that the User is collecting the Falling Objects with
    /// </summary>
    [Serializable]
    public class Collector
    {
        // the bounds of the collector
        private int maxX, maxY;
        private int minX, minY;

        /// <summary>
        /// Gets or sets the current location of the Collector
        /// </summary>
        public Point Location { get; set; }
        /// <summary>
        /// Gets or sets the current Rectangle of the Collector
        /// </summary>
        public Rectangle Rectangle { get; set; }
        /// <summary>
        /// The image that represents the Collector
        /// </summary>
        public Bitmap Image { get; set; }

        // static variables for adjusting the rectangle of the image
        public static int PADDING_X = 20;
        public static int PADDING_Y = 35;
        public static int PADDING_WIDTH = 35;

        public Collector()
        {
            UpdateDataResize();
            Location = new Point(Game.WIDTH_OF_FORM / 2, minY);
        }

        /// <summary>
        /// Updates the info that is being affected by a resize of the GameForm
        /// </summary>
        public void UpdateDataResize()
        {
            minY = Game.HEIGHT_OF_FORM - 100;
            maxY = Game.HEIGHT_OF_FORM - 85;
            minX = 40;
            maxX = Game.WIDTH_OF_FORM - 70;
        }

        /// <summary>
        /// Draws the Collector
        /// </summary>
        /// <param name="g">Graphics object</param>
        public void Draw(Graphics g)
        {
            g.DrawImageUnscaled(Image, Location.X - Game.SIZE_OF_COLLECTOR.Width / 2,
                Location.Y - Game.SIZE_OF_COLLECTOR.Height / 2,
                Game.SIZE_OF_COLLECTOR.Width, Game.SIZE_OF_COLLECTOR.Height);
        }

        /// <summary>
        /// Checks if the new location is in bounds, and moves the Collector accordingly
        /// </summary>
        /// <param name="newLocation">The new location of the Collector</param>
        public void Move(Point newLocation)
        {
            int x = 0, y = 0;
            
            // checks bounderies
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

            Rectangle = new Rectangle(Location.X - Game.SIZE_OF_COLLECTOR.Width / 2 + PADDING_X,
                Location.Y - Game.SIZE_OF_COLLECTOR.Height / 2 + PADDING_Y, Image.Size.Width - PADDING_WIDTH, Image.Size.Height);
        }
    }
}
