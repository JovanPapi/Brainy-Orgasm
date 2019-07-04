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
            FillPaths();
        }

        protected override void FillPictureList()
        {
            Player.Collector.Image = new Bitmap(Properties.Resources.visualStudio, SIZE_OF_COLLECTOR);
            BackgroundImage = new Bitmap(Properties.Resources.backgroundOfVS, SIZE_OF_BACKGROUND_IMAGE);
            pictures.Enqueue(new Bitmap(Properties.Resources.C_, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.C__, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.Java, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.NodeJs, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.PHP, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.PowerShell, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.RichGo, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.Ruby, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.VisualBasic, SIZE_OF_FALLING_OBJECT));
            pictures.Enqueue(new Bitmap(Properties.Resources.Python, SIZE_OF_FALLING_OBJECT));
        }

        protected override void FillPaths()
        {
            pathsToContentFiles.Enqueue(new Content("c#.txt", Properties.Resources.C_1, Properties.Resources.C_));
            pathsToContentFiles.Enqueue(new Content("C++.txt", Properties.Resources.C__1, Properties.Resources.C__));
            pathsToContentFiles.Enqueue(new Content("Java.txt", Properties.Resources.Java1, Properties.Resources.Java));
            pathsToContentFiles.Enqueue(new Content("NodeJS.txt", Properties.Resources.NodeJs1, Properties.Resources.NodeJs));
            pathsToContentFiles.Enqueue(new Content("PHP.txt", Properties.Resources.PHP1, Properties.Resources.PHP));
            pathsToContentFiles.Enqueue(new Content("PowerShell.txt", Properties.Resources.PowerShell1, Properties.Resources.PowerShell));
            pathsToContentFiles.Enqueue(new Content("Rich GO.txt", Properties.Resources.RichGo1, Properties.Resources.RichGo));
            pathsToContentFiles.Enqueue(new Content("Ruby.txt", Properties.Resources.Ruby1, Properties.Resources.Ruby));
            pathsToContentFiles.Enqueue(new Content("Visual Basic.txt", Properties.Resources.VisualBasic1, Properties.Resources.VisualBasic));
            pathsToContentFiles.Enqueue(new Content("Python.txt", Properties.Resources.Python1, Properties.Resources.Python));
        }
    }
}
