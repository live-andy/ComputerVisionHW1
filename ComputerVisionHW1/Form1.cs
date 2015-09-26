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
    public partial class Form1 : Form
    {
        public Form1()
        {
            int a = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TurnBlackButton_Click(object sender, EventArgs e)
        {
            try
            {
                //並宣告bm1為Bitmap
                Bitmap bm1 = (Bitmap)MainPictureBox.Image;
                //宣告寬及高
                int OriginalWidth = MainPictureBox.Image.Width;
                int OriginalHeight = MainPictureBox.Image.Height;
                int x;
                int y;
                //掃影像每一個pixel並做處理
                for (y = 0; y <= OriginalHeight - 1; y++)
                {
                    for (x = 0; x <= OriginalWidth - 1; x++)
                    {
                        Color OriginalColor = bm1.GetPixel(x, y);
                        int Red_Original = OriginalColor.R;
                        int Green_Original = OriginalColor.G;
                        int Blue_Original = OriginalColor.B;
                        int avg1 = (Red_Original + Green_Original + Blue_Original) / 3;
                        bm1.SetPixel(x, y, Color.FromArgb(avg1, avg1, avg1));
                    }
                }
                //處理完後放回MainPictureBox
                MainPictureBox.Image = bm1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog LoadImageDialog = new OpenFileDialog();
            LoadImageDialog.Filter = "JPG(*.jpg)|*.jpg|" + "BMP(*.BMP)|*.bmp|" + "GIF(*.GIT)|*.gif|" + "所有檔案|*.*";
            if(LoadImageDialog.ShowDialog() == DialogResult.OK)
            {
                MainPictureBox.Width = Image.FromFile(LoadImageDialog.FileName).Width;
                MainPictureBox.Height = Image.FromFile(LoadImageDialog.FileName).Height;
                MainPictureBox.Image = Image.FromFile(LoadImageDialog.FileName);
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            Bitmap bm2 = (Bitmap)MainPictureBox.Image;
            Form2 newForm = new Form2();
            newForm.Form2GetImage(bm2);
            newForm.Show();
        }
    }
}
