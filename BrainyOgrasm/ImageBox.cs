using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    /// <summary>
    /// Class that represents an image that moves down
    /// </summary>
    public class ImageBox
    {
        /// <summary>
        /// Location of the image
        /// </summary>
        protected Point location;

        /// <summary>
        /// Gets or sets the image
        /// </summary>
        public Bitmap Image { get; set; }

        public ImageBox(Point imageLocation, Image img)
        {
            Image = new Bitmap(img);
            location = imageLocation;
        }

        /// <summary>
        /// Method for drawing the image
        /// </summary>
        /// <param name="g">Graphics object</param>
        public virtual void Draw(Graphics g)
        {
            g.DrawImage(Image, location.X, location.Y, 30, 30);
        }

        /// <summary>
        /// Method for moving the image
        /// </summary>
        public virtual void Move()
        {
            this.location = new Point(location.X, location.Y + 30);
        }

        /// <summary>
        /// Checks if the object has left the panel
        /// </summary>
        /// <returns>True, if the object has left the panel</returns>
        public virtual bool IsOutOfBounds()
        {
            return location.Y > ListImages.PANEL_HEIGHT + 60;
        }
    }
}
