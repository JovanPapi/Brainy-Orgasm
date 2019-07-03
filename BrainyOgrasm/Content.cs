using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    public class Content
    {
        public string MainContent { get; set; }
        public string MainTitle { get; set; }
        public string SubDomainTitle { get; set; }
        public Bitmap FallingImage { get; set; }
        public Bitmap OtherImage { get; set; }

        public Content(string mainContent, string mainTitle, string subDomainTitle, Bitmap fallingImage, Bitmap otherImage)
        {
            MainContent = mainContent;
            MainTitle = mainTitle;
            SubDomainTitle = subDomainTitle;
            FallingImage = fallingImage;
            OtherImage = otherImage;
        }
    }
}
