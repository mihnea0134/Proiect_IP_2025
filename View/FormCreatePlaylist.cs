using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaPlayer.Core.Interfaces;
using MediaPlayer.Presenter;
using System.Linq;

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
                MessageBox.Show("A fost o eroare la incarcare, selectati din nou.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SetSelectedFiles()
        {
            listBoxSongsForPlaylist.Items.Clear();
            listBoxSongsForPlaylist.Items.AddRange(SelectedMedia.ToArray());
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            CloseView();
        }
    }
}
