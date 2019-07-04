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
            FillPaths();
        }

        protected override void FillPictureList()
        {
            Player.Collector.Image = new Bitmap(Properties.Resources.lamp, SIZE_OF_COLLECTOR);
            BackgroundImage = new Bitmap(Properties.Resources.brain, SIZE_OF_BACKGROUND_IMAGE);
            pictures.Enqueue(new Bitmap(Properties.Resources.AlbertEinstein, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.CharlesDarwin, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.IsaacNewton, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.JohannesFeynman, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.JohannesKepler, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.MarieCurie, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.NikolaTesla, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.OttoHahn, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.ThomasEdison, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.Galileo, SIZE_OF_FALLING_OBJECT));
        }

        protected override void FillPaths()
        {
            pathsToContentFiles.Enqueue(new Content("Albert Einstein.txt", Properties.Resources.Albert1, Properties.Resources.Albert2));
            pathsToContentFiles.Enqueue(new Content("Charles Darwin.txt", Properties.Resources.CharlesDarwin1, Properties.Resources.CharlesDarwin2));
            pathsToContentFiles.Enqueue(new Content("Isaac Newton.txt", Properties.Resources.Newton1, Properties.Resources.Newton2));
            pathsToContentFiles.Enqueue(new Content("Richard Feynman.txt", Properties.Resources.RichardFeynam1, Properties.Resources.RichardFeynam2));
            pathsToContentFiles.Enqueue(new Content("Johannes Kepler.txt", Properties.Resources.JohannesKepler1, Properties.Resources.JohannesKepler2));
            pathsToContentFiles.Enqueue(new Content("Marie Curie.txt", Properties.Resources.Marie1, Properties.Resources.Marie2));
            pathsToContentFiles.Enqueue(new Content("Nikola Tesla.txt", Properties.Resources.Tesla1, Properties.Resources.Tesla2));
            pathsToContentFiles.Enqueue(new Content("Otto Hahn.txt", Properties.Resources.OttoHan1, Properties.Resources.OttoHan2));
            pathsToContentFiles.Enqueue(new Content("Thomas Edison.txt", Properties.Resources.Edison1, Properties.Resources.Edison2));
            pathsToContentFiles.Enqueue(new Content("Galileo Galilei.txt", Properties.Resources.GalileoGalilei1, Properties.Resources.GalileoGalilei2));
        }
    }
}
