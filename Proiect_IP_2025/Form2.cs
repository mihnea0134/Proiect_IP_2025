using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Proiect_IP_2025
{
    public partial class Form2 : Form
    {

        public string PlaylistNameResult { get; private set; }
        public List<string> SelectedSongs { get; private set; } = new List<string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        

        private void PlaylistName_TextChanged(object sender, EventArgs e)
        {
        }

        private void CreatePlaylist_Click(object sender, EventArgs e)
        {
            string name = PlaylistName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name for the playlist.");
                return;
            }

            if (SelectedSongs.Count == 0)
            {
                MessageBox.Show("Please add at least one song.");
                return;
            }

            PlaylistNameResult = name;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddSongsPlaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "MP3 files|*.mp3",
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var song in ofd.FileNames)
                {
                    if (!SelectedSongs.Contains(song))
                    {
                        SelectedSongs.Add(song);
                        SongsForPlaylistListBox.Items.Add(Path.GetFileName(song));
                    }
                }
            }
        }
    }
}
