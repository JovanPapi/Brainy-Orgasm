using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{

    public class ImageBox
    {
        public Point ImageLocation { get; set; }
        public Image OriginalImage { get; set; }
        public const int ImageWidth = 30;
        public const int ImageHeight = 30;

        public ImageBox(Point imageLocation, Image img)
        {
            OriginalImage = img;
            ImageLocation = imageLocation;
        }

        /// <summary>
        /// Method for drawing an image
        /// </summary>
        /// <param name="g">Graphics object</param>
        public void DrawImage(Graphics g)
        {
            g.DrawImage(OriginalImage, ImageLocation.X, ImageLocation.Y, ImageWidth, ImageHeight);
        }

        /// <summary>
        /// Method for moving an image
        /// </summary>
        public void MoveImageLocation()
        {
            this.ImageLocation = new Point(ImageLocation.X, ImageLocation.Y + 30);
        }
    }
}
