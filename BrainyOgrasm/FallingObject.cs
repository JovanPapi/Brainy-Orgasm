using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    /// <summary>
    /// Class that represents the falling objects in the game
    /// </summary>
    public class FallingObject
    {
        /// <summary>
        /// Rectangle of falling object
        /// </summary>
        private Rectangle rectangle;
        /// <summary>
        /// Location of the falling object
        /// </summary>
        private Point location;

        /// <summary>
        /// Gets or sets the image that represents the falling object
        /// </summary>
        public Bitmap Image { get; set; }
        /// <summary>
        /// Can the object be collected
        /// </summary>
        public bool Invincible { get; set; }

        /// <summary>
        /// Constructor for FallingObject
        /// </summary>
        /// <param name="image">The image that represents the falling object</param>
        /// <param name="location">The default location of the falling object</param>
        public FallingObject(Bitmap image, Point location)
        {
            this.Image = image;
            this.location = location;
            rectangle = new Rectangle(location, image.Size);
            Invincible = false;
        }

        /// <summary>
        /// Moves the falling object
        /// </summary>
        /// <returns>True, if the object has left the form</returns>
        public bool Move()
        {
            location = new Point(location.X, location.Y + 10);
            rectangle = new Rectangle(location, Image.Size);

            if (location.Y >= Game.HEIGHT_OF_FORM - 60)
                Invincible = true;

            if (location.Y + Game.SIZE_OF_FALLING_OBJECT.Height >= Game.HEIGHT_OF_FORM)
                return true;
            return false;
        }

        /// <summary>
        /// Draws the falling object
        /// </summary>
        /// <param name="g">Graphics object</param>
        public void Draw(Graphics g)
        {
            g.DrawImageUnscaled(Image, location.X, location.Y,
                Game.SIZE_OF_FALLING_OBJECT.Width, Game.SIZE_OF_FALLING_OBJECT.Height);
        }

        /// <summary>
        /// Checks if the falling object has collided with the player's Collector
        /// </summary>
        /// <param name="rectangleOfPlayer">Rectangle of the Collector</param>
        /// <returns>True, if the objects are colliding</returns>
        public bool Collide(Rectangle rectangleOfPlayer)
        {
            return rectangle.IntersectsWith(rectangleOfPlayer);
        }

        /// <summary>
        /// Checks if the object is out of GameForm's bounderies when resizing
        /// </summary>
        /// <returns>True, if falling object is not in GameForm bounderies</returns>
        public bool IsOutOfBounds()
        {
            return location.X + 70 >= Game.WIDTH_OF_FORM || location.Y + 70 >= Game.HEIGHT_OF_FORM;
        }
    }
}