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
        private int buttonSize = 30;
        private int buttonGap = 10;
        private int margin = 20;
        private int topMargin = 40;
        private int timeRemaining;
        private List<List<Button>> buttons = new List<List<Button>>();

        private void ButtonClicked(object sender, EventArgs e)
        {

        }

        private void CreateButton(int x, int y)
        {
            int positionX = margin + x * (buttonSize + buttonGap);
            int positionY = margin + y * (buttonSize + buttonGap) + topMargin;

            if(x == 0)
            {
                buttons.Add(new List<Button>());
            }
            buttons[x].Add(new Button());
            buttons[x][y].Location = new Point(positionX, positionY);
            buttons[x][y].Size = new Size(buttonSize, buttonSize);
            buttons[x][y].Click += new System.EventHandler(this.ButtonClicked);
            this.Controls.Add(buttons[x][y]);
        }

        public Form2(int n, int k)
        {
            int size = margin * 2 + n * buttonSize + (n - 1) * buttonGap; ;

            InitializeComponent();
            this.Width = size + 15;
            this.Height = size + 40 + topMargin;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    CreateButton(i, j);
                }
            }
            timeRemaining = k * 30;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRemaining--;
            label1.Text = (timeRemaining / 10.0).ToString();
        }
    }
}
