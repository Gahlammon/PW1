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
            dataGridView1.Rows.RemoveAt(index);
        }
        private void addToList(string name, string nationality, string role)
        {
            dataGridView1.Rows.Add(name, nationality, role);
        }
        private void recreateDataGrid()
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            for (int i = 0; i < names.Count; i++)
            {
                addToList(names[i], nationalities[i], roles[i]);
            }
        }
        public void newRecord(string name, string nationality, string role)
        {
            bool correctRole = false;
            for (int i = 0; i < avaiableRoles.Length; i++)
            {
                if (role == avaiableRoles[i])
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
        private void saveData(string path)
        {
            string output = "";
            for (int i = 0; i < names.Count; i++)
            {
                output += names[i] + ";" + nationalities[i] + ";" + roles[i] + ";";
            }
            File.WriteAllText(path, output);
        }
        private void loadData(string path)
        {
            string input = File.ReadAllText(path);
            names = new List<string>();
            nationalities = new List<string>();
            roles = new List<string>();
            while (input != "")
            {
                names.Add(input.Substring(0,input.IndexOf(';')));
                input = input.Substring(input.IndexOf(';') + 1, input.Length - input.IndexOf(';') - 1);
                nationalities.Add(input.Substring(0, input.IndexOf(';')));
                input = input.Substring(input.IndexOf(';') + 1, input.Length - input.IndexOf(';') - 1);
                roles.Add(input.Substring(0, input.IndexOf(';')));
                input = input.Substring(input.IndexOf(';') + 1, input.Length - input.IndexOf(';') - 1);
            }
            recreateDataGrid();
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

        private void button6_Click(object sender, EventArgs e)
        {
            saveData("Data.csv");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadData("Data.csv");
        }
    }
}
