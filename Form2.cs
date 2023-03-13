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
        private Form1 f1;
        private double price = 0.0;
        private int currentRadio = -1;
        private double[] hardDiskPrice = { 5, 10, 15 };

        public Form2(Form1 parent)
        {
            InitializeComponent();
            f1 = parent;
        }
        
        private void newPrice(double value)
        {
            price = value;
            label5.Text = price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.setPrice(price);
            Close();
        }

        private void radioClicked(int num)
        {
            double value = price;

            if(currentRadio != -1)
            {
                value -= hardDiskPrice[currentRadio];
            }
            value += hardDiskPrice[num];
            currentRadio = num;
            newPrice(value);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioClicked(0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioClicked(1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioClicked(2);
        }
    }
}
