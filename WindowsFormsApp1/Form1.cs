
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace WindowsFormsApp1
{
  
    public partial class Form1 : Form
    {
        private Image<Gray, byte> grayimg;
        private Image<Bgr, byte> img = null;
        private Image<Gray, byte> binaryimg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dlg = new OpenFileDialog();
            if (open_dlg.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Bgr, byte>(open_dlg.FileName);
            }
            if (img != null)
            {
                pictureBox1.Image = img.ToBitmap();
            }
        }

        private void btn_gray_Click(object sender, EventArgs e)
        {
            grayimg = img.Convert<Gray, byte>();
            pictureBox2.Image = grayimg.ToBitmap();
        }

        private void row_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void column_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private Image<Gray, byte> Dilation(Image<Gray, byte> binaryimg, int ker_row, int ker_column)
        {
            int h = binaryimg.Height;
            int w = binaryimg.Width;
            int half_column = (ker_column - 1) / 2;
            int half_row = (ker_row - 1) / 2;
            Image<Gray, byte> dilationimg = binaryimg.CopyBlank();
              int i, j, k, l;

            for (i = 1; i < h - 1; i++)
            {
                for (j = 1; j < w - 1; j++)
                {
                    if (binaryimg.Data[i, j, 0] == 255)
                        for (k = -half_row; k <= half_row; k++)
                            for (l = -half_column; l <= half_column; l++)
                                if (k != 0 && l != 0)
                                    dilationimg.Data[i + k, j + l, 0] = 255;
                                else continue;
                    else continue;
                }
            }
            return dilationimg;
        }
        private Image<Gray, byte> Erosion(Image<Gray, byte> binaryimg, int ker_row, int ker_column)
        {
            //Define kernel rows, columns
            int half_column = (ker_column - 1) / 2;
            int half_row = (ker_row - 1) / 2;

            int h = binaryimg.Height;
            int w = binaryimg.Width;

            Image<Gray, byte> erosionimg = binaryimg.CopyBlank();

            int i, j, k, l;
            for (i = 1; i < h - 1; i++)
            {
                for (j = 1; j < w - 1; j++)
                {
                    if (binaryimg.Data[i, j, 0] == 255)
                    {
                        int count = 0; //variable to count neighbor under Bz
                        for (k = -half_row; k <= half_row; k++)
                            for (l = -half_column; l <= half_column; l++)
                            {
                                if (binaryimg.Data[i + k, j + l, 0] == 255) count += 1;
                                else continue;
                            }
                        if (count == ker_row * ker_column) erosionimg.Data[i, j, 0] = 255;
                    }
                    else continue;
                }
            }
            return erosionimg;
        }

        private void dilation_btn_Click(object sender, EventArgs e)
        {
            //Define kernel rows, columns
            int ker_row = Convert.ToInt16(row_txtbox.Text);
            int ker_column = Convert.ToInt16(column_txtbox.Text);
            Image <Gray, Byte> dilationimg = binaryimg.CopyBlank();
            dilationimg = Dilation(binaryimg, ker_row, ker_column);
            pictureBox2.Image = dilationimg.ToBitmap();
        }

        private void erosion_btn_Click(object sender, EventArgs e)
        {
            //Define kernel rows, columns
            int ker_row = Convert.ToInt16(row_txtbox.Text);
            int ker_column = Convert.ToInt16(column_txtbox.Text);
            Image<Gray, Byte> erosionimg = binaryimg.CopyBlank();
            erosionimg=Erosion(binaryimg, ker_row, ker_column);
            pictureBox2.Image = erosionimg.ToBitmap();
        }

        private void otsu_btn_Click(object sender, EventArgs e)
        {
            binaryimg = grayimg.CopyBlank();
            CvInvoke.Threshold(grayimg, binaryimg, 0, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
            CvInvoke.AdaptiveThreshold(grayimg, binaryimg, 255,
            Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC,
            Emgu.CV.CvEnum.ThresholdType.Binary, 17, 0);
            pictureBox2.Image = binaryimg.ToBitmap();
        }

        private void opening_btn_Click(object sender, EventArgs e)
        {
            int ker_row = Convert.ToInt16(row_txtbox.Text);
            int ker_column = Convert.ToInt16(column_txtbox.Text);
            Image<Gray,Byte> openingimg = binaryimg.CopyBlank();
            openingimg = Erosion(binaryimg, ker_row, ker_column);
            openingimg = Dilation(openingimg, ker_row, ker_column);
            pictureBox2.Image = openingimg.ToBitmap();
        }


        private void closing_btn_Click(object sender, EventArgs e)
        {
            int ker_row = Convert.ToInt16(row_txtbox.Text);
            int ker_column = Convert.ToInt16(column_txtbox.Text);
            Image<Gray, Byte> closingimg = binaryimg.CopyBlank();
            closingimg = Dilation(binaryimg, ker_row, ker_column);
            closingimg = Erosion(closingimg, ker_row, ker_column);
            pictureBox2.Image = closingimg.ToBitmap();
        }
    }
}
