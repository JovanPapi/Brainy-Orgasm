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
            pathsToContentFiles = new Queue<ContentWrapper>();
            FillPaths();
        }

        private void FillPaths()
        {
            pathsToContentFiles.Enqueue(new ContentWrapper("Black Hole.txt", Properties.Resources.BlackHole1, Properties.Resources.BlackHole2));
            pathsToContentFiles.Enqueue(new ContentWrapper("Exo Planet.txt", Properties.Resources.ExoPlanet1, Properties.Resources.ExoPlanet2));
            pathsToContentFiles.Enqueue(new ContentWrapper("Galaxy.txt", Properties.Resources.Galaxy1, Properties.Resources.Galaxy2));
            pathsToContentFiles.Enqueue(new ContentWrapper("The Sun.txt", Properties.Resources.Sun1, Properties.Resources.Sun2));
            pathsToContentFiles.Enqueue(new ContentWrapper("Blue Giant.txt", Properties.Resources.BlueGiant1, Properties.Resources.BlueGiant2));
            pathsToContentFiles.Enqueue(new ContentWrapper("Io Moon.txt", Properties.Resources.IoMoon1, Properties.Resources.IoMoon2));
            pathsToContentFiles.Enqueue(new ContentWrapper("Comet.txt", Properties.Resources.Comet1, Properties.Resources.Comet2));
            pathsToContentFiles.Enqueue(new ContentWrapper("Nebula.txt", Properties.Resources.CrabNebula1, Properties.Resources.CrabNebula2));
            pathsToContentFiles.Enqueue(new ContentWrapper("Golden Record.txt", Properties.Resources.GoldenDisk1, Properties.Resources.GoldenDisk2));
            pathsToContentFiles.Enqueue(new ContentWrapper("Asteroid.txt", Properties.Resources.Asteroid1, Properties.Resources.Asteroid2));
        }

        protected override void FillPictureList()
        {
            Player.Collector.Image = new Bitmap(Properties.Resources.blackHole, SIZE_OF_COLLECTOR);
            BackgroundImage = new Bitmap(Properties.Resources.MilkyWay, SIZE_OF_BACKGROUND_IMAGE);
            pictures.Add(new Bitmap(Properties.Resources.fallingBlackHole, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.exo_planet, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.galaxy, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.sun, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.blueGiant, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.IoMoon, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.comet, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.nebula, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.GoldenDisk, SIZE_OF_FALLING_OBJECT));
            pictures.Add(new Bitmap(Properties.Resources.Asteroid, SIZE_OF_FALLING_OBJECT));
        }

        public override Content ChooseContent()
        {
            ContentWrapper current = pathsToContentFiles.Dequeue();
            return new Content(ContentFromFile(@"~\..\..\..\Content\"+current.PathToFile), "Universe", 
                current.PathToFile.Split(".".ToCharArray())[0],
                current.Image1, current.Image2);
        }
    }
}
