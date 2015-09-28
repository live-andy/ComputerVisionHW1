using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVisionHW1
{
    public partial class Form2 : Form
    {
        bool check;
        public Form2()
        {
            InitializeComponent();
        }
        public void Form2GetImage(Bitmap InputImage)
        {
            ResultPictureBox.Width = InputImage.Width;
            ResultPictureBox.Height = InputImage.Height;
            ResultPictureBox.Image = InputImage;
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            if(check == false)
            {
                this.Opacity = 0.5;
                check = true;
            }
            else
            {
                this.Opacity = 1;
                check = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            check = false;
        }
    }
}
