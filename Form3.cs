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
    public partial class Form3 : Form
    {
        private Form1 f1;
        private int channel;
        private double price = 1.0;
        public Form3(Form1 parent, int c)
        {
            InitializeComponent();
            f1 = parent;
            channel = c;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.setPrice(price, channel);
            Close();
        }
    }
}
