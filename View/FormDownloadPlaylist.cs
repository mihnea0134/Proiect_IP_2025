using MediaPlayer.Core.Interfaces;
using MediaPlayer.Core.Models;
using MediaPlayer.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaPlayer.View
{
    public partial class FormDownloadPlaylist : Form, IDownloadPlaylistView
    {
        private readonly IDownloadPlaylistPresenter _presenter;
        private readonly IModel _model;
        public string FilterText => textBoxFilter.Text;
        public Playlist SelectedPlaylist => listBoxPlaylists.SelectedItem as Playlist;

        public FormDownloadPlaylist(IModel model)
        {
            _model = model;
            _presenter = new DownloadPlaylistPresenter(this, _model);
            InitializeComponent();
        }

        public void SetPlaylists(List<Playlist> playlists)
        {
            listBoxPlaylists.Items.Clear();
            listBoxPlaylists.Items.AddRange(playlists.ToArray());
        }

        public void SetMedia(List<string> songs)
        {
            listBoxMedia.Items.Clear();
            listBoxMedia.Items.AddRange(songs.ToArray());
        }

        public void ShowMessage(string message, string title)
        {
            MessageBoxIcon icon = title == "Eroare" ? MessageBoxIcon.Warning : MessageBoxIcon.Information;
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        public void CloseView()
        {
            try
            {
                Close();
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Formul a fost deja inchis!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Nu se poate inchide formul!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            await _presenter.SearchPlaylistsAsync();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            CloseView();
        }

        private void ListBoxPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.OnPlaylistSelected();
        }

        private async void ButtonDownload_Click(object sender, EventArgs e)
        {
            await _presenter.DownloadSelectedPlaylistAsync();
        }
    }
}
