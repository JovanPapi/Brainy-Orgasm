using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainyOgrasm
{
    public partial class ContentForm : Form
    {
        public ContentForm(Content content)
        {
            InitializeComponent();
            txtMainContent.Text = content.MainContent;
            lblMainTitle.Text = content.MainTitle;
            lblSubDomainTitle.Text = content.SubDomainTitle;
            pbFalling.Image = content.FallingImage;
            pbOther.Image = content.OtherImage;
            ChangeSize();
        }

        private void ChangeSize()
        {
            Size sizeOfContent = TextRenderer.MeasureText(txtMainContent.Text, txtMainContent.Font);
            this.Height = sizeOfContent.Height + (this.Height - txtMainContent.Height);
            txtMainContent.Size = sizeOfContent;
        }
    }
}
