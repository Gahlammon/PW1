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
        private List<SoundPlayer> tracks = new List<SoundPlayer>();
        private int currentTrack = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile()
        {
            OpenFileDialog fileOpener = new OpenFileDialog();
            SoundPlayer loader = new SoundPlayer();

            fileOpener.Title = "Select audio file";
            fileOpener.Filter = "wav files (*.wav)|*.wav";

            if(fileOpener.ShowDialog() == DialogResult.OK)
            {
                loader.SoundLocation = fileOpener.FileName;
                tracks.Add(loader);
                listView1.Items.Add(fileOpener.FileName);
            }
        }
        private void RemoveFile()
        {
            while (listView1.SelectedItems.Count > 0)
            {
                tracks.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
        }
        private void Play()
        {
            tracks[currentTrack].Play();
        }
        private void Stop()
        {
            tracks[currentTrack].Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            RemoveFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play();
        }

    }
}
