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
        private int size;
        private int targets;
        private int buttonSize = 30;
        private int buttonGap = 10;
        private int margin = 20;
        private int topMargin = 40;
        private int timeRemaining;
        private List<List<Button>> buttons = new List<List<Button>>();
        private List<List<bool>> target = new List<List<bool>>();

        private void ButtonClicked(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (buttons[i][j] == sender)
                    {
                        x = i;
                        y = j;
                        break;
                    }
                }
            }
            buttons[x][y].Enabled = false;
            if (target[x][y])
            {
                buttons[x][y].BackColor = Color.Green;
            }
            else
            {
                buttons[x][y].BackColor = Color.Red;
            }
        }

        private void AddTargets()
        {
            List<int> numbers = new List<int>();
            int decision;
            int chosen;
            var randomGenerator = new Random();

            for (int i = 0; i < size * size; i++)
            {
                numbers.Add(i);
            }
            for (int i = 0; i < targets; i++)
            {
                chosen = randomGenerator.Next(0, size * size - i);
                decision = numbers[chosen];
                numbers.RemoveAt(chosen);
                target[decision / 5][decision % 5] = true;
            }
        }

        private void CreateButton(int x, int y)
        {
            int positionX = margin + x * (buttonSize + buttonGap);
            int positionY = margin + y * (buttonSize + buttonGap) + topMargin;

            if(x == 0)
            {
                buttons.Add(new List<Button>());
                target.Add(new List<bool>());
            }
            buttons[x].Add(new Button());
            target[x].Add(new bool());
            buttons[x][y].Location = new Point(positionX, positionY);
            buttons[x][y].Size = new Size(buttonSize, buttonSize);
            buttons[x][y].Click += new System.EventHandler(this.ButtonClicked);
            target[x][y] = false;
            this.Controls.Add(buttons[x][y]);
        }

        public Form2(int n, int k)
        {
            size = n;
            targets = k;
            int pixelSize = margin * 2 + n * buttonSize + (n - 1) * buttonGap; ;

            InitializeComponent();
            this.Width = pixelSize + 15;
            this.Height = pixelSize + 40 + topMargin;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    CreateButton(i, j);
                }
            }
            AddTargets();
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
