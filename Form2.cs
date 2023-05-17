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
    public partial class Form2 : Form
    {
        private string allowedSigns = "aAcCgGtT";
        private string chain;
        private Dictionary<string, int> fours = new Dictionary<string, int>();

        private string ChainCleaner(string input)
        {
            bool matches;

            for(int i = 0; i < input.Length; i++)
            {
                matches = false;
                for(int j = 0; j < allowedSigns.Length; j++)
                {
                    if (input[i] == allowedSigns[j])
                    {
                        matches = true;
                        break;
                    }
                }
                if (!matches)
                {
                    input = input.Substring(0, i) + input.Substring(i + 1, input.Length - i - 1);
                    i--;
                }
            }

            return input;
        }
        private Dictionary<string, int> GenerateDictionary(string input)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            string key;
            int value;

            for(int i = 0; i < input.Length - 3; i++)
            {
                key = input.Substring(i, 4);
                if (output.TryGetValue(key, out value))
                {
                    output[key]++;
                }
                else
                {
                    output.Add(key, 1);
                }
            }

            return output;
        }
        private void DictionaryToGridView(Dictionary<string, int> input)
        {
            string key;

            while(input.Any())
            {
                key = input.Last().Key;
                dataGridView1.Rows.Add(key, input[key]);
                input.Remove(key);
            }
        }
        private void saveData(DataGridView input, string path)
        {
            string output = "";

            for(int i=0;i<input.Rows.Count;i++)
            {
                output += input.Rows[i].Cells[0].Value + "," + input.Rows[i].Cells[1].Value + ",";
            }

            File.WriteAllText(path, output);
        }
        public Form2(string input)
        {
            InitializeComponent();

            chain = ChainCleaner(input);
            label1.Text = chain;
            fours = GenerateDictionary(chain);
            DictionaryToGridView(fours);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveData(dataGridView1, "DNA.csv");
        }
    }
}
