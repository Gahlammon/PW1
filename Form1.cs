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
using System.Media;

namespace Project1
{
    public partial class Form1 : Form
    {
        int card_count = 26;
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            listView_BOT.Visible = false;
        }

        private void War_button_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void W_card_view_Click(object sender, EventArgs e)
        {

        }

        private void BJ_Button_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            //panel1.Visible = false;
        }

        private void W_card_button_Click(object sender, EventArgs e)
        {

        }

        private void BJ_stop_button_Click(object sender, EventArgs e)
        {
            listView_BOT.Visible = true;
        }
    }
}
