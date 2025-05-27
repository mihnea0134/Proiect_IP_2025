using Proiect_IP_2025.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_IP_2025
{
    public partial class Form1 : Form
    {
        private MusicController controller;
        private MusicModel model;

        public Form1()
        {
            InitializeComponent();

            model = new MusicModel();
            VolumeBar.Minimum = 0;
            VolumeBar.Maximum = 100;
            VolumeBar.Value = 50; // Default volume: 50%
            controller = new MusicController(model, QueueList, SongLabelTitle, ArtistLabel,pictureBox1,VolumeBar,PositionBar,TimeLabel,playlistList);
        }

        private void AddMusicButton_Click(object sender, EventArgs e)
        {
            controller.AddSong();

        }

        private void QueueList_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.SelectSong(QueueList.SelectedIndex);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SongLabelTitle_Click(object sender, EventArgs e)
        {

        }

        private void ArtistLabel_Click(object sender, EventArgs e)
        {

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            controller.Previous();
        }

        private void Play_StopButton_Click(object sender, EventArgs e)
        {
            controller.PlayPause();

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            controller.Next();

        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            controller.SetVolume(VolumeBar.Value / 100f);

        }

        private void PositionBar_Scroll(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreatePlaylist_Click(object sender, EventArgs e)
        {
            using (Form2 form = new Form2())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string playlistName = form.PlaylistNameResult;
                    List<string> songs = form.SelectedSongs;

                    controller.CreatePlaylist(playlistName);
                    foreach (var song in songs)
                    {
                        model.Playlists[playlistName].Add(song);
                    }

                    playlistList.SelectedItem = playlistName;
                    controller.SelectPlaylist(playlistName);
                }
            }
        }

        

        private void SavePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void playlistList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
