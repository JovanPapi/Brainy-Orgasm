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
            pbFalling.Image = new Bitmap(content.Image1, pbFalling.Size);
            pbOther.Image = new Bitmap(content.Image2, pbOther.Size);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
