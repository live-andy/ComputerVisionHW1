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
            Bitmap HeHeBitmap;
            if (RotateVariable.Text != "")
            {
                int SafeWidth = NewPictureWidth;
                int SafeHeight = NewPictureHeight;
                int theta = Convert.ToInt32(RotateVariable.Text);
                int XOffset;    //X補正量
                int YOffset;    //Y補正量
                theta = theta % 360;
                //theta = 360 - theta;
                double Radian = (theta * Math.PI) / 180;
                double CosTheta = Math.Cos(Radian);
                double SinTheta = Math.Sin(Radian);
                int SmallestX;  //最小X
                int SmallestY;  //最小Y
                int GreatX; //最大X
                int GreatY; //最大Y
                //X
                int XofRightTop = Convert.ToInt32(Math.Floor(NewPictureWidth * CosTheta));
                int XofLeftDown = Convert.ToInt32(Math.Floor(-NewPictureHeight * SinTheta));
                int XofRightDown = Convert.ToInt32(Math.Floor(NewPictureWidth * CosTheta - NewPictureHeight * SinTheta));
                SmallestX = 0;
                if (SmallestX > XofRightTop) SmallestX = XofRightTop;
                if (SmallestX > XofLeftDown) SmallestX = XofLeftDown;
                if (SmallestX > XofRightDown) SmallestX = XofRightDown;
                GreatX = 0;
                if (GreatX < XofRightTop) GreatX = XofRightTop;
                if (GreatX < XofLeftDown) GreatX = XofLeftDown;
                if (GreatX < XofRightDown) GreatX = XofRightDown;
                //Y
                int YofRightTop = Convert.ToInt32(Math.Floor(NewPictureWidth * SinTheta));
                int YofLeftDown = Convert.ToInt32(Math.Floor(NewPictureHeight * CosTheta));
                int YofRightDown = Convert.ToInt32(Math.Floor(NewPictureWidth * SinTheta + NewPictureHeight * SinTheta));
                SmallestY = 0;
                if (SmallestY > YofRightTop) SmallestY = YofRightTop;
                if (SmallestY > YofLeftDown) SmallestY = YofLeftDown;
                if (SmallestY > YofRightDown) SmallestY = YofRightDown;
                GreatY = 0;
                if (GreatY < YofRightTop) GreatY = YofRightTop;
                if (GreatY < YofLeftDown) GreatY = YofLeftDown;
                if (GreatY < YofRightDown) GreatY = YofRightDown;
                NewPictureWidth = GreatX - SmallestX;
                NewPictureHeight = GreatY - SmallestY;
                HeHeBitmap = new Bitmap(NewPictureWidth, NewPictureHeight);
                if(0 <= theta & theta <= 90)
                {
                    XOffset = 0;
                    YOffset = Math.Abs(0 - SmallestY);
                    MessageBox.Show(YOffset.ToString() + "  " + SmallestY.ToString());

                    
                }
                else if(91 <= theta & theta <= 269)
                {
                    XOffset = Math.Abs(0 - SmallestX);
                    YOffset = Math.Abs(0 - SmallestY);
                }
                else
                {
                    XOffset = Math.Abs(0 - SmallestX);
                    YOffset = 0;
                }
                for (int i = 0; i < NewPictureWidth; i++)
                {
                    for(int j = 0; j < NewPictureHeight; j++)
                    {
                        int OriginalXPos = Convert.ToInt32(Math.Floor((i-XOffset) * CosTheta - (j - YOffset) * SinTheta));
                        int OriginalYPos = Convert.ToInt32(Math.Floor((i-XOffset) * SinTheta + (j - YOffset) * CosTheta));
                        if(OriginalXPos >= 0 & OriginalXPos < SafeWidth & OriginalYPos >= 0 & OriginalYPos < SafeHeight)
                        {
                            HeHeBitmap.SetPixel(i, j, NewBitmap.GetPixel(OriginalXPos, OriginalYPos));
                        }
                    }
                }
            }
            else
            {
                HeHeBitmap = NewBitmap;
            }
            //平移
            int XMovementData = 0;
            int YMovementData = 0;
            Color Black = Color.FromArgb(255, 255, 255);
            if (XMovement.Text != "")
            {
                XMovementData = Convert.ToInt32(XMovement.Text);
            }
            if (YMovement.Text != "")
            {
                YMovementData = Convert.ToInt32(XMovement.Text);
            }
            NewPictureWidth = NewPictureWidth + XMovementData;
            NewPictureHeight = NewPictureHeight + YMovementData;
            Bitmap HaHaBitmap = new Bitmap(NewPictureWidth, NewPictureHeight);
            for(int i = 0; i < NewPictureWidth; i++)
            {
                for(int j = 0; j < NewPictureHeight; j++)
                {
                    if((i - XMovementData) < 0 | (j - YMovementData < 0))
                    {
                        HaHaBitmap.SetPixel(i,j,Black);
                    }
                    else
                    {
                        HaHaBitmap.SetPixel(i, j, HeHeBitmap.GetPixel(i - XMovementData, j - YMovementData));
                    }
                }
            }
            /*Send image to form2*/
            Form2 newForm = new Form2();
            newForm.Form2GetImage(HaHaBitmap);
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
