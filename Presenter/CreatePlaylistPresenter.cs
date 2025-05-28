using MediaPlayer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MediaPlayer.Presenter
{
    public class CreatePlaylistPresenter: ICreatePlaylistPresenter
    {
        private readonly ICreatePlaylistView _view;

        public CreatePlaylistPresenter(ICreatePlaylistView view)
        {
            _view = view;
        }

        public Dictionary<string, DialogResult> OnClickCreatePlaylist()
        {
            string name = _view.PlaylistNameInput.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                _view.ShowMessage("Dati un nume concret.", "Eroare");
                return null;
            }

            return new Dictionary<string, DialogResult> { { name, DialogResult.OK } };
        }

        public string OnClickAddMediaToPlaylist(List<string> selectedMedia)
        {
            bool changed = false;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "MP3 files|*.mp3",
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string media in ofd.FileNames)
                {
                    if (!selectedMedia.Contains(media))
                    {
                        try
                        {
                            selectedMedia.Add(Path.GetFileName(media));
                        }
                        catch (ArgumentException)
                        {
                            return "Eroare la adaugarea media.";
                        }
                        changed = true;
                    }
                }
            }

            return changed ? "Schimbat" : "";
        }
    }
}
