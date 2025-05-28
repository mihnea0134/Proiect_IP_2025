using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaPlayer.Core.Interfaces;
using MediaPlayer.Presenter;
using System.Linq;
using System.IO;
using MediaPlayer.Core.Models;


namespace MediaPlayer.View
{
    public partial class FormCreatePlaylist : Form, ICreatePlaylistView
    {
        public string PlaylistNameResult { get; private set; }
        public List<string> SelectedMedia { get; private set; } = new List<string>();
        public string PlaylistNameInput => textBoxPlaylistName.Text;
        private readonly ICreatePlaylistPresenter _presenter;

        public FormCreatePlaylist()
        {
            _presenter = new CreatePlaylistPresenter(this);
            InitializeComponent();
        }     

        private void CreatePlaylist_Click(object sender, EventArgs e)
        {
            Dictionary<string,DialogResult> result = _presenter.OnClickCreatePlaylist();

            if (result != null && result.Count > 0)
            {
                PlaylistNameResult = result.First().Key;
                DialogResult = result.First().Value;
            }
        }

        private void AddMediaToPlaylist_Click(object sender, EventArgs e)
        {
            string message = _presenter.OnClickAddMediaToPlaylist(SelectedMedia);
            if (message == "Schimbat")
            {
                SetSelectedFiles();
            }
            else if (message != "")
            {
                ShowMessage("A fost o eroare la incarcare, selectati din nou.", "Eroare");
            }
        }

        public void SetSelectedFiles()
        {
            listBoxSongsForPlaylist.Items.Clear();
            
            listBoxSongsForPlaylist.Items.AddRange(SelectedMedia.Select(media => Path.GetFileNameWithoutExtension(media)).ToArray());
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
                ShowMessage("Formul a fost deja inchis!", "Eroare");
            }
            catch (InvalidOperationException)
            {
                ShowMessage("Nu se poate inchide formul!", "Eroare");
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            CloseView();
        }
    }
}
