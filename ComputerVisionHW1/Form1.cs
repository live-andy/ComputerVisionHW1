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
            Bitmap OriginalBitmap = (Bitmap)MainPictureBox.Image;
            //拉申
            //下面這邊要用估計(round)的 還沒寫
            double WidthData = 1;
            double HeightData = 1;
            if (WidthVariable.Text != "") WidthData = Convert.ToDouble(WidthVariable.Text);
            if(HeightVariable.Text != "") HeightData = Convert.ToDouble(HeightVariable.Text);
            int NewPictureWidth = Convert.ToInt32(Math.Round(WidthData * OriginalBitmap.Width,0));
            int NewPictureHeight = Convert.ToInt32(Math.Round(HeightData * OriginalBitmap.Height,0));
            double OriginalX;
            double OriginalY;
            Bitmap NewBitmap = new Bitmap(NewPictureWidth, NewPictureHeight);
            for (int i = 0; i < NewPictureWidth; i++)
            {
                for (int j = 0; j < NewPictureHeight; j++)
                {
                    OriginalX = i / WidthData;
                    OriginalY = j / HeightData;
                    /*
                    Color LeftUp = OriginalBitmap.GetPixel(Convert.ToInt32(Math.Floor(OriginalX)), Convert.ToInt32(Math.Floor(OriginalY)));
                    Color LeftDown = OriginalBitmap.GetPixel(Convert.ToInt32(Math.Floor(OriginalX)), Convert.ToInt32(Math.Ceiling(OriginalY)));
                    Color RightUp = OriginalBitmap.GetPixel(Convert.ToInt32(Math.Ceiling(OriginalX)), Convert.ToInt32(Math.Floor(OriginalY)));
                    Color RightDown = OriginalBitmap.GetPixel(Convert.ToInt32(Math.Ceiling(OriginalX)), Convert.ToInt32(Math.Ceiling(OriginalY)));
                    */
                    Color OriginalColor = OriginalBitmap.GetPixel(Convert.ToInt32(Math.Floor(OriginalX)), Convert.ToInt32(Math.Floor(OriginalY)));
                    /*int Red = OriginalColor.R;
                    int Green = OriginalColor.G;
                    int Blue = OriginalColor.B;*/
                    //NewBitmap.SetPixel(i,j, Color.FromArgb(avg1, avg1, avg1)));
                    NewBitmap.SetPixel(i, j, OriginalColor);
                }
            }
            //旋轉


            //平移
            int XMovementData;
            int YMovementData;
            if (XMovement.Text != "")
            {
                XMovementData = Convert.ToInt32(XMovement.Text);
            }
            if (YMovement.Text != "")
            {
                YMovementData = Convert.ToInt32(XMovement.Text);
            }
            /*Send image to form2*/
            Form2 newForm = new Form2();
            newForm.Form2GetImage(NewBitmap);
            newForm.Show();
        }

        private void XMovement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)  //force user to enter numbers
            {
                e.Handled = true;
            }
        }

        private void YMovement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void WidthVariable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void HeightVariable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void RotateVariable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
