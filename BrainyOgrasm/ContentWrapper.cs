using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    public class ContentWrapper
    {
        public string PathToFile { get; set; }
        public Bitmap Image1 { get; set; }
        public Bitmap Image2 { get; set; }

        public ContentWrapper(string pathToFile, Bitmap image1, Bitmap image2)
        {
            PathToFile = pathToFile;
            Image1 = image1;
            Image2 = image2;
        }
    }
}
