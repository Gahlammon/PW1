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
using System.Xml;
using System.Xml.Serialization;

namespace Project1
{
    [Serializable]
    public partial class Form1 : Form
    {
        private HeroList dataList = new HeroList();
        private string[] avaiableRoles = { "Tank", "Natarcie", "Wsparcie" };

        public Form1()
        {
            InitializeComponent();
        }

        private void removeFromList(int index)
        {
            dataList.heroes.RemoveAt(index);
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
            for (int i = 0; i < dataList.heroes.Count; i++)
            {
                addToList(dataList.heroes[i].name, dataList.heroes[i].nationality, dataList.heroes[i].role);
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
                dataList.heroes.Add(new Hero(name, nationality, role));
                addToList(name, nationality, role);
            }
        }
        private void saveDataCsv(string path)
        {
            string output = "";
            for (int i = 0; i < dataList.heroes.Count; i++)
            {
                output += dataList.heroes[i].name + "," + dataList.heroes[i].nationality + "," + dataList.heroes[i].role + ",";
            }
            File.WriteAllText(path, output);
        }
        private void loadDataCsv(string path)
        {
            string input = File.ReadAllText(path);
            string name;
            string nationality;
            string role;
            dataList = new HeroList();
            while (input != "")
            {
                name = input.Substring(0,input.IndexOf(','));
                input = input.Substring(input.IndexOf(',') + 1, input.Length - input.IndexOf(',') - 1);
                nationality = input.Substring(0, input.IndexOf(','));
                input = input.Substring(input.IndexOf(',') + 1, input.Length - input.IndexOf(',') - 1);
                role = input.Substring(0, input.IndexOf(','));
                input = input.Substring(input.IndexOf(',') + 1, input.Length - input.IndexOf(',') - 1);
                dataList.heroes.Add(new Hero(name, nationality, role));
            }
            recreateDataGrid();
        }
        private void loadDataXml(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Hero>));
            StreamReader reader = new StreamReader(path);
            dataList.heroes = (List<Hero>)serializer.Deserialize(reader);
            reader.Close();
            recreateDataGrid();
        }
        private void saveDataXml(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Hero>));
            StreamWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, dataList.heroes);
            writer.Close();
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
            if (dataGridView1.Rows.Count > 0)
            {
                while (dataGridView1.SelectedRows.Count > 1)
                {
                    removeFromList(dataGridView1.SelectedRows[0].Index);
                }
                removeFromList(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveDataCsv("Data.csv");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadDataCsv("Data.csv");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 creator = new Form3(dataList.heroes);
            creator.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveDataXml("Data.xml");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadDataXml("Data.xml");
        }
    }
}
