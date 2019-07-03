using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    class VSGame : Game
    {
        public VSGame(User player) : base(player)
        {
            FillPictureList();
            InitializeCollector();
            ColorOfPoints = Color.White;
        }

        protected override void FillPictureList()
        {
            Player.Collector.Image = new Bitmap(Properties.Resources.visualStudio, SIZE_OF_COLLECTOR);
            BackgroundImage = new Bitmap(Properties.Resources.backgroundOfVS, SIZE_OF_BACKGROUND_IMAGE);
            pictures.Add(new Bitmap(Properties.Resources.C_, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.C__, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.Java, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.NodeJs, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.PHP, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.PowerShell, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.RichGo, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.Ruby, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.VisualBasic, SIZE_OF_FALLING_OBJECT));
        }

        public override Content ChooseContent()
        {
            throw new NotImplementedException();
        }
    }
}
