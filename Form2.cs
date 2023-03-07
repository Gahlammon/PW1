using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form2 : Form
    {
        public bool isStoperRunning = false;
        DateTime startTime = DateTime.Now;
        DateTime stopTime = DateTime.Now;
        TimeSpan stoper;
        TimeSpan additionalTime = TimeSpan.Zero;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            label1.ForeColor = Color.Red;
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            stopTime = DateTime.Now;
            additionalTime = stopTime - startTime;
            label1.ForeColor = Color.Black;
            timer1.Stop();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            stopTime = DateTime.Now;
            additionalTime = TimeSpan.Zero;
            label1.Text = additionalTime.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            stoper = DateTime.Now - startTime + additionalTime;
            label1.Text = stoper.ToString();
        }
    }
}
