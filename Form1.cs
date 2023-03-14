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
    public partial class Form1 : Form
    {
        private double[] prices;

        public Form1()
        {
            InitializeComponent();
            prices = new double[2];
            prices[0] = 0;
            prices[1] = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this,0);
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this,1);
            f3.ShowDialog();
        }
        public void displayPrice()
        {
            double value = 0;
            for(int i = 0; i < prices.Length; i++)
            {
                value += prices[i];
            }
            label1.Text = value.ToString();
        }
        public void setPrice(double price, int channel)
        {
            prices[channel] = price;
            displayPrice();
        }
    }
}
