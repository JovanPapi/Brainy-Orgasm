using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    public class ScientistsGame : Game
    {

        public ScientistsGame(User player) : base(player)
        {
            FillPictureList();
            InitializeCollector();
            ColorOfPoints = Color.Black;
        }

        protected override void FillPictureList()
        {
            Player.Collector.Image = new Bitmap(Properties.Resources.lamp, SIZE_OF_COLLECTOR);
            BackgroundImage = new Bitmap(Properties.Resources.brain, SIZE_OF_BACKGROUND_IMAGE);
            pictures.Add(new Bitmap(Properties.Resources.AlbertEinstein, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.CharlesDarwin, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.IsaacNewton, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.JohannesFeynman, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.JohannesKepler, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.MarieCurie, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.NikolaTesla, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.OttoHahn, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.ThomasEdison, SIZE_OF_FALLING_OBJECT));
        }
    }
}
