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
        private List<Hero> heroes;

        public Form3(List<Hero> input)
        {
            InitializeComponent();
            heroes = input;
        }
        private void addToList(string name, string nationality, string role)
        {
            dataGridView1.Rows.Add(name, nationality, role);
        }
        private void showDataGridSearch(string input)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            for (int i = 0; i < heroes.Count; i++)
            {
                if (heroes[i].name.ToLower().Contains(input.ToLower()) || heroes[i].nationality.ToLower().Contains(input.ToLower()) || heroes[i].role.ToLower().Contains(input.ToLower()))
                {
                    addToList(heroes[i].name, heroes[i].nationality, heroes[i].role);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showDataGridSearch(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
