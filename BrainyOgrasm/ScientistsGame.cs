using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    /// <summary>
    /// Class that represents the Scientists Mode
    /// </summary>
    public class ScientistsGame : Game
    {
        /// <summary>
        /// Constuctor for ScientistsGame
        /// </summary>
        /// <param name="player">The User that is currently playing</param>
        public ScientistsGame(User player) : base(player)
        {
            FillPicturesQueue();
            InitializeCollector();
            ColorOfPoints = Color.Black;
            FillPaths();
        }

        protected override void FillPicturesQueue()
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
            contents.Enqueue(new Content("Albert Einstein.txt", Properties.Resources.Albert1, Properties.Resources.Albert2));
            contents.Enqueue(new Content("Charles Darwin.txt", Properties.Resources.CharlesDarwin1, Properties.Resources.CharlesDarwin2));
            contents.Enqueue(new Content("Isaac Newton.txt", Properties.Resources.Newton1, Properties.Resources.Newton2));
            contents.Enqueue(new Content("Richard Feynman.txt", Properties.Resources.RichardFeynam1, Properties.Resources.RichardFeynam2));
            contents.Enqueue(new Content("Johannes Kepler.txt", Properties.Resources.JohannesKepler1, Properties.Resources.JohannesKepler2));
            contents.Enqueue(new Content("Marie Curie.txt", Properties.Resources.Marie1, Properties.Resources.Marie2));
            contents.Enqueue(new Content("Nikola Tesla.txt", Properties.Resources.Tesla1, Properties.Resources.Tesla2));
            contents.Enqueue(new Content("Otto Hahn.txt", Properties.Resources.OttoHan1, Properties.Resources.OttoHan2));
            contents.Enqueue(new Content("Thomas Edison.txt", Properties.Resources.Edison1, Properties.Resources.Edison2));
            contents.Enqueue(new Content("Galileo Galilei.txt", Properties.Resources.GalileoGalilei1, Properties.Resources.GalileoGalilei2));
        }
    }
}
