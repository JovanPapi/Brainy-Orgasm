﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    public class FallingObject
    {
        private Rectangle rectagnleOfObject;
        private Point location;

        public Bitmap Image { get; set; }

        public FallingObject(Bitmap image, Point location)
        {
            this.Image = image;
            this.location = location;
            rectagnleOfObject = new Rectangle(location, image.Size);
        }

        public bool Move()
        {
            location = new Point(location.X, location.Y + 10);
            rectagnleOfObject = new Rectangle(location, Image.Size);
            if (location.Y + 50 >= Game.HEIGHT_OF_FORM)
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
            //Rectangle tmp = new Rectangle(new Point(rectangleOfPlayer.X, rectangleOfPlayer.Y),
            // new Size(rectangleOfPlayer.Width, rectangleOfPlayer.Height));
            return rectagnleOfObject.IntersectsWith(rectangleOfPlayer);
        }
    }
}
