using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    public class FallingObject
    {
        private Rectangle rectangle;
        private Point location;

        public Bitmap Image { get; set; }
        public bool Invincible { get; set; }

        public FallingObject(Bitmap image, Point location)
        {
            this.Image = image;
            this.location = location;
            rectangle = new Rectangle(location, image.Size);
            Invincible = false;
        }

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

        public void Draw(Graphics g)
        {
            g.DrawImageUnscaled(Image, location.X, location.Y,
                Game.SIZE_OF_FALLING_OBJECT.Width, Game.SIZE_OF_FALLING_OBJECT.Height);
        }

        public bool Collide(Rectangle rectangleOfPlayer)
        {
            return rectangle.IntersectsWith(rectangleOfPlayer);
        }

        public bool IsOutOfBounds()
        {
            return location.X - 70 >= Game.WIDTH_OF_FORM || location.Y >= Game.HEIGHT_OF_FORM;
        }
    }
}