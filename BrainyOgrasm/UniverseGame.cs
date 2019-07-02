using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainyOgrasm
{
    public class UniverseGame : Game
    {
        public UniverseGame(User player) : base(player)
        {
            FillPictureList();
            InitializeCollector();
            ColorOfPoints = Color.White;
        }

        protected override void FillPictureList()
        {
            Player.Collector.Image = new Bitmap(Properties.Resources.blackHole, SIZE_OF_COLLECTOR);
            BackgroundImage = new Bitmap(Properties.Resources.MilkyWay, SIZE_OF_BACKGROUND_IMAGE);
            //pictures.Add(new Bitmap(Properties.Resources.meteor, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.fallingBlackHole, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.exo_planet, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.galaxy, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.sun, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.blueGiant, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.supernova, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.comet, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.nebula, SIZE_OF_FALLING_OBJECT));
        }
    }
}
