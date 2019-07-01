using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainyOgrasm
{
    public partial class MainForm : Form
    {
        private ListImages images;
        private ListImages images2;
        private Random rNumber;
        private int countNumber;
        private string ImagePath;
        public static List<Users> users = new List<Users>();
        FileStream stream;
        private int count;


        public MainForm()
        {
            InitializeComponent();

            images = new ListImages();
            images2 = new ListImages();
            rNumber = new Random();
            this.DoubleBuffered = true;
            count = 0;
            stream = null;

            string FilePath = @"..\..\Users.db";
            try
            {
                stream = new FileStream(FilePath, FileMode.Open);
                IFormatter f = new BinaryFormatter();
                users = (List<Users>)f.Deserialize(stream);
                stream.Dispose();
            }
            catch (FileNotFoundException)
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Game cannot be started");
            }

            users.Sort();
            countNumber = 1;

            ImagePath = @"..\..\Images\" + 15 + ".jpg";

            pbLogoOfTheGame.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogoOfTheGame.BorderStyle = BorderStyle.Fixed3D;
            pbLogoOfTheGame.Image = Image.FromFile(ImagePath);
            this.MaximizeBox = false;

            MoveImages.Enabled = true;
            MoveImages.Start();
        }
        private void MoveImages_Tick(object sender, EventArgs e)
        {
            if (count % 1000 == 0)
            {
                ImagePath = null;
                if (countNumber == 19)
                {
                    countNumber = 1;
                    images.Images.Clear();
                }
                else
                {
                    if (countNumber == 5)
                        ImagePath = @"..\..\Images\" + countNumber + ".png";
                    else
                    {
                        ImagePath = @"..\..\Images\" + countNumber + ".jpg";
                    }
                    images.AddImage(new ImageBox(new Point(rNumber.Next(panelLeft.Location.X - 10, panelLeft.Location.X + 50), panelLeft.Location.Y - 40), ImagePath));
                    images2.AddImage(new ImageBox(new Point(rNumber.Next(panelRight.Location.X - 10, panelRight.Location.X + 50), panelRight.Location.Y - 40), ImagePath));
                    countNumber++;
                }
            }
            count += 500;
            images.MoveImages(panelLeft.Height);
            images2.MoveImages(panelRight.Height);
            Invalidate(true);
        }

        private void PanelsLeftRight_DrawImages(object sender, PaintEventArgs e)
        {
            images.DrawImages(e.Graphics);
            images2.DrawImages(e.Graphics);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            MoveImages.Enabled = false;
            HighScoresForm form = new HighScoresForm();
            if (form.ShowDialog() == DialogResult.Cancel)
                MoveImages.Enabled = true;
        }

        public void SerializeUsers()
        {
            string FilePath = @"..\..\Users.db";
            try
            {
                stream = new FileStream(FilePath, FileMode.Create);
                IFormatter f = new BinaryFormatter();
                f.Serialize(stream, users);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                stream.Dispose();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            MoveImages.Enabled = false;
            NewGameUserInput form = new NewGameUserInput();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (users.Contains(form.user))
                {
                    return;
                }
                else
                    users.Add(form.user);
                /*PlayGameForm form = new PlayGameForm();
                form.ShowDialog();*/
            }
            else
                MoveImages.Enabled = true;
        }
        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            MoveImages.Enabled = false;
            HowToPlayForm form = new HowToPlayForm();
            if (form.ShowDialog() == DialogResult.Cancel)
                MoveImages.Enabled = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeUsers();
        }
    }
}
