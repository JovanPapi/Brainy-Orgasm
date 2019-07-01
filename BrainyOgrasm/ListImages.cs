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

        public void DrawImages(Graphics g)
        {
            foreach (ImageBox im in Images)
            {
                im.DrawImage(g);
            }
        }

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

        public void AddImage(ImageBox newImage)
        {
            Images.Add(newImage);
        }
    }
}
