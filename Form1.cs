using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project1
{
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void negativeColor()
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(255 - image.GetPixel(i, j).R), Convert.ToInt32(255 - image.GetPixel(i, j).G), Convert.ToInt32(255 - image.GetPixel(i, j).B)));
                }
            }
        }
        private void multiplyColor(float R, float G, float B)
        {
            for(int i = 0; i < image.Width; i++) 
            {
                for (int j = 0; j < image.Height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(image.GetPixel(i,j).R * R), Convert.ToInt32(image.GetPixel(i, j).G * G), Convert.ToInt32(image.GetPixel(i, j).B * B)));
                }
            }
        }
        private void updateImage()
        {
            pictureBox1.Image = image;
        }
        private void loadImage(string path)
        {
            Image input = Image.FromStream(File.Open(path,FileMode.Open));
            image = new Bitmap(input);
            updateImage();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadImage("Image.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            multiplyColor(0, 1, 0);
            updateImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            negativeColor();
            updateImage();
        }
    }
}
