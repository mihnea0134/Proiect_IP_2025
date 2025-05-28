using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaPlayer.Core.Interfaces;
using MediaPlayer.Core.Models;
using System.Linq;

namespace MediaPlayer.View
{
    public partial class FormAudioMediaPlayer : Form, IView
    {
        private IPresenter _presenter;
        private IModel _model;
        private int _mediaIndex = 0;

        public FormAudioMediaPlayer()
        {
            InitializeComponent();
        }

        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter;
            _presenter.LoadAllPlaylists();
        }

        public void SetModel(IModel model)
        {
            _model = model;
        }

        private void ButtonCreatePlaylist_Click(object sender, EventArgs e)
        {
            FormCreatePlaylist createPlaylistForm = new FormCreatePlaylist();

            if(createPlaylistForm.ShowDialog() == DialogResult.OK)
            {
                _presenter.CreateNewPlaylist(createPlaylistForm.PlaylistNameResult, createPlaylistForm.SelectedMedia);
            }
        }

        private void ButtonUploadDeleteOnlinePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDownloadOnlinePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDeletePlaylist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Esti sigur ca doresti sa stergi playlist-ul {listBoxPlaylist.SelectedItem.ToString()}?", "Confirma Stergerea", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _presenter.DeleteSelectedPlaylist();
                buttonDeletePlaylist.Enabled = false;
                buttonDeleteMedia.Enabled = false;
                buttonUploadDeleteOnlinePlaylist.Enabled = false;
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPlayStop_Click(object sender, EventArgs e)
        {
            _presenter.PlayAndPause();
        }

        private void ListBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeletePlaylist.Enabled = true;
            buttonUploadDeleteOnlinePlaylist.Enabled = true;
            buttonDeleteMedia.Enabled = false;
            groupBoxPlaybackMethods.Enabled = false;
            buttonPlayPause.Enabled = false;
            if (listBoxPlaylist.SelectedIndex != -1)
            {
                listBoxPlaylistAudioMedia.Items.Clear();
                listBoxPlaylistAudioMedia.Tag = listBoxPlaylist.SelectedItem;
                listBoxPlaylistAudioMedia.Items.AddRange(_model.GetPlaylistLocal(listBoxPlaylist.SelectedItem.ToString()).Media.Select(am => am.Title).ToArray());
            }
        }

        private void TrackBarTime_Scroll(object sender, EventArgs e)
        {

        }

        private void TrackBarVolume_Scroll(object sender, EventArgs e)
        {

        }

        private void ButtonDeleteMedia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Esti sigur ca doresti sa stergi media-ul {listBoxPlaylistAudioMedia.SelectedItem.ToString()}?", "Confirma Stergerea", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _presenter.DeleteSelectedAudioMedia(listBoxPlaylistAudioMedia.Tag.ToString(), listBoxPlaylistAudioMedia.SelectedItem.ToString());
                buttonDeletePlaylist.Enabled = false;
                buttonDeleteMedia.Enabled = false;
                buttonUploadDeleteOnlinePlaylist.Enabled = false;
                groupBoxPlaybackMethods.Enabled = false;
                buttonPlayPause.Enabled = false;
            }
        }

        public void ClearItem(string audioMediaName)
        {
            listBoxPlaylistAudioMedia.Items.Remove(audioMediaName);
        }

        public void DisplayPlaylists(List<Playlist> playlists)
        {
            listBoxPlaylist.Items.Clear();
            foreach (Playlist pl in playlists)
            {
                listBoxPlaylist.Items.Add(pl.Name);
            }
        }

        public void ChangePlayButtonText()
        {
            buttonPlayPause.Text = buttonPlayPause.Text == "Portneste redarea" ? "Pauza" : "Porneste redarea";
        }

        public void ShowMessage(string message, string title)
        {
            MessageBoxIcon icon = title == "Eroare" ? MessageBoxIcon.Warning : MessageBoxIcon.Information;
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        public void ClearPlaylistDisplay()
        {
            listBoxPlaylistAudioMedia.Items.Clear();
        }

        public string GetSelectedPlaylistName()
        {
            return listBoxPlaylist.SelectedItem.ToString();
        }

        public void DisplayMediaItems(List<AudioMedia> mediaList)
        {
            listBoxPlaylistAudioMedia.Items.Clear();
            foreach (AudioMedia media in mediaList)
            {
                listBoxPlaylistAudioMedia.Items.Add(media.Title);
            }
        }

        private void FormAudioMediaPlayer_Click(object sender, EventArgs e)
        {
            listBoxPlaylist.ClearSelected();
            listBoxPlaylistAudioMedia.ClearSelected();

            buttonDeletePlaylist.Enabled = false;
            buttonDeleteMedia.Enabled = false;
            buttonUploadDeleteOnlinePlaylist.Enabled = false;
            groupBoxPlaybackMethods.Enabled = false;
            buttonPlayPause.Enabled = false;
        }

        private void ButtonAddMediaToPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxPlaylistAudioMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteMedia.Enabled = true;
            groupBoxPlaybackMethods.Enabled = true;
            buttonPlayPause.Enabled = true;
        }
    }
}
