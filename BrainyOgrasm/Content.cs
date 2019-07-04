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
        public string PathToFile { get; set; }
        public string MainContent { get; set; }
        public string MainTitle { get; set; }
        public string SubDomainTitle { get; set; }
        public Bitmap Image1 { get; set; }
        public Bitmap Image2 { get; set; }

        public Content(string pathToFile, Bitmap image1, Bitmap image2)
        {
            PathToFile = pathToFile;
            Image1 = image1;
            Image2 = image2;
        }

        public void FillContent(string contentsOfFile, Mode gameMode)
        {
            MainContent = contentsOfFile;
            MainTitle = gameMode == Mode.VisualStudio ? "Visual Studio" : gameMode.ToString();
            SubDomainTitle = PathToFile.Split(".".ToCharArray())[0];
        }
    }
}
