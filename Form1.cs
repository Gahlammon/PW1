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
        private List<string> names = new List<string>();
        private List<string> nationalities = new List<string>();
        private List<string> roles = new List<string>();
        private string[] avaiableRoles = { "Tank", "Natarcie", "Wsparcie" };

        public Form1()
        {
            InitializeComponent();
        }

        private void removeFromList(int index)
        {
            names.RemoveAt(index);
            nationalities.RemoveAt(index);
            roles.RemoveAt(index);
            dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
        }
        private void addToList(string name, string nationality, string role)
        {
            dataGridView1.Rows.Add(name, nationality, role);
        }
        public void newRecord(string name, string nationality, string role)
        {
            bool correctRole = false;
            for(int i=0; i<avaiableRoles.Length; i++)
            {
                if(role == avaiableRoles[i])
                {
                    correctRole = true;
                    break;
                }
            }
            if (correctRole)
            {
                names.Add(name);
                nationalities.Add(nationality);
                roles.Add(role);
                addToList(name, nationality, role);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 creator = new Form2(this);
            creator.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (dataGridView1.SelectedRows.Count > 1)
            {
                removeFromList(dataGridView1.SelectedRows[0].Index);
            }
            removeFromList(dataGridView1.SelectedRows[0].Index);
        }
    }
}
