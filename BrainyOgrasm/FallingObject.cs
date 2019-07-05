using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    /// <summary>
    /// Class that represents the falling objects in the GameForm
    /// </summary>
    public class FallingObject : ImageBox
    {
        /// <summary>
        /// Rectangle of falling object
        /// </summary>
        private Rectangle rectangle;

        /// <summary>
        /// Can the object be collected
        /// </summary>
        public bool Invincible { get; set; }

        /// <summary>
        /// Constructor for FallingObject
        /// </summary>
        /// <param name="image">The image that represents the falling object</param>
        /// <param name="location">The default location of the falling object</param>
        public FallingObject(Bitmap image, Point location) : base(location, image)
        {
            rectangle = new Rectangle(location, image.Size);
            Invincible = false;
        }

        /// <summary>
        /// Method for moving the image
        /// </summary>
        public override void Move()
        {
            location = new Point(location.X, location.Y + 10);
            rectangle = new Rectangle(location, Image.Size);

            if (location.Y >= Game.HEIGHT_OF_FORM - 60)
                Invincible = true;
        }

        /// <summary>
        /// Method for drawing the image
        /// </summary>
        /// <param name="g">Graphics object</param>
        public override void Draw(Graphics g)
        {
            g.DrawImageUnscaled(Image, location.X, location.Y,
                Game.SIZE_OF_FALLING_OBJECT.Width, Game.SIZE_OF_FALLING_OBJECT.Height);
        }

        /// <summary>
        /// Checks if the object is out of GameForm's bounderies when resizing
        /// </summary>
        /// <returns>True, if falling object is not in GameForm bounderies</returns>
        public override bool IsOutOfBounds()
        {
            return location.X + 70 >= Game.WIDTH_OF_FORM || location.Y + 70 >= Game.HEIGHT_OF_FORM;
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
    }
}