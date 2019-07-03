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
        public ContentForm()
        {
            InitializeComponent();
            txtMainContent.Text = ""; 
        }

        private void txtMainContent_TextChanged(object sender, EventArgs e)
        {
            Size sifeOfContent = TextRenderer.MeasureText(txtMainContent.Text, txtMainContent.Font);
            txtMainContent.Size = sifeOfContent;
            if(txtMainContent.Height > this.Height)
            {
                
            }
        }
    }
}
