﻿using System;
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
        private string ImagePath;
        public static List<User> users;
        FileStream stream;
        private int count;
        private List<Image> mainImages;


        public MainForm()
        {
            InitializeComponent();

            images = new ListImages();
            images2 = new ListImages();
            mainImages = new List<Image>();
            rNumber = new Random();


            this.DoubleBuffered = true;
            count = 0;
            stream = null;

            string FilePath = @"..\..\Users.db";
            try
            {
                stream = new FileStream(FilePath, FileMode.Open);
                IFormatter f = new BinaryFormatter();
                users = (List<User>)f.Deserialize(stream);
                stream.Dispose();
            }
            catch (FileNotFoundException)
            { 
                users = new List<User>();
            }
            catch (Exception)
            {
                MessageBox.Show("Game cannot be started");
            }

            users.Sort();

            pbLogoOfTheGame.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogoOfTheGame.BorderStyle = BorderStyle.Fixed3D;
            pbLogoOfTheGame.Image = Properties.Resources.logo;
            this.MaximizeBox = false;

            FillMainImages();

            MoveImages.Enabled = true;
            MoveImages.Start();
            
        }
        private void FillMainImages()
        {
            mainImages.Add(Properties.Resources.AlbertEinstein);
            mainImages.Add(Properties.Resources.comet);
            mainImages.Add(Properties.Resources.emoji);
            mainImages.Add(Properties.Resources.galaxy);
            mainImages.Add(Properties.Resources.lamp);
            mainImages.Add(Properties.Resources.MilkyWay);
            mainImages.Add(Properties.Resources.nebula);
        }
        private void MoveImages_Tick(object sender, EventArgs e)
        {
            if (count % 1000 == 0)
            {

                images.AddImage(new ImageBox(new Point(rNumber.Next(panelLeft.Location.X - 10,
                    panelLeft.Location.X + 50), panelLeft.Location.Y - 40), mainImages[rNumber.Next(0, 7)]));

            }
            count += 500;
            images.MoveImages(panelLeft.Height);
            Invalidate(true);
        }

        private void PanelsLeftRight_DrawImages(object sender, PaintEventArgs e)
        {
            images.DrawImages(e.Graphics);
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
