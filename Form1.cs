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
        public Form1()
        {
            InitializeComponent();
        }

        private int StringValue(string input)
        {
            int output;
            bool success = int.TryParse(input, out output);
            if (!success)
            {
                output = 0;
            }
            return output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(StringValue(textBox1.Text), StringValue(textBox2.Text));
            newForm.ShowDialog();
        }
    }
}
