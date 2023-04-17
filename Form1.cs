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
    }
}
