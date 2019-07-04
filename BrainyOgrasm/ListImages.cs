using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    public class ListImages
    {
        public List<ImageBox> Images { get; set; }

        public ListImages()
        {
            this.Images = new List<ImageBox>();
        }

        /// <summary>
        /// Method that lists all images and draws them
        /// </summary>
        /// <param name="g">Graphics object</param>
        public void DrawImages(Graphics g)
        {
            foreach (ImageBox im in Images)
            {
                im.DrawImage(g);
            }
        }

        /// <summary>
        /// Method that lists all images and moves them 
        /// </summary>
        /// <param name="panelHeight">The height of the panel</param>
        public void MoveImages(int panelHeight)
        {
            for (int i = 0; i < Images.Count; i++)
            {
                if (Images[i].ImageLocation.Y > panelHeight + 60)
                {
                    Images.Remove(Images[i]); 
                }
                else
                    Images[i].MoveImageLocation();
            }
        }

        /// <summary>
        /// Method that adds one image in the list of images
        /// </summary>
        /// <param name="newImage">The image that is going to be shown on the panels</param>
        public void AddImage(ImageBox newImage)
        {
            Images.Add(newImage);
        }
    }
}
