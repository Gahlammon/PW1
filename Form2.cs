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
        public Form2()
        {
            InitializeComponent();
        }

        private void Resault_label_Click(object sender, EventArgs e)
        {
            /*
            if (resault = 1)
            {
                Resault_label.Text = "Win";
            }
            else
            {
                Resault_label.Text = "Lose";
            }
            */
            

        }

        private void New_game_button_Click(object sender, EventArgs e)
        {
            //"reset" form1
            this.Close();
        }
    }
}
