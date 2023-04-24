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

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        Form2 form = new Form2();
                        form.ShowDialog();
                        break;
                    }
                case 1:
                    {
                        Form4 form = new Form4();
                        form.ShowDialog();
                        break;
                    }
                case 2:
                    {
                        Form5 form = new Form5();
                        form.ShowDialog();
                        break;
                    }
                case 3:
                    {
                        Form6 form = new Form6();
                        form.ShowDialog();
                        break;
                    }
            }
        }
    }
}
