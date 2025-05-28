using MediaPlayer.Core.Interfaces;
using MediaPlayer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;

namespace MediaPlayer.Presenter
{
    public class DownloadPlaylistPresenter: IDownloadPlaylistPresenter
    {
        private readonly IDownloadPlaylistView _view;
        private readonly IModel _model;

        private List<Playlist> _currentPlaylists = new List<Playlist>();

        public DownloadPlaylistPresenter(IDownloadPlaylistView view, IModel model)
        {
            _view = view;
            _model = model;
        }

        public async Task SearchPlaylistsAsync()
        {
            try
            {
                string query = _view.FilterText;
                _currentPlaylists = string.IsNullOrWhiteSpace(query) ? await _model.GetAllPlaylistsAsync() : await _model.SearchPlaylistsAsync(query);
                _view.SetPlaylists(_currentPlaylists);
            }
            catch (Exception)
            {
                _view.ShowMessage($"Eroare la cautare.", "Eroare");
            }
        }

        public void OnPlaylistSelected()
        {
            Playlist selected = _view.SelectedPlaylist;
            if (selected != null)
            {
                _view.SetMedia(selected.Media.Select(m => m.Title).ToList());
            }
            else
            {
                _view.SetMedia(new List<string>());
            }
        }

        public async Task DownloadSelectedPlaylistAsync()
        {
            Playlist playlist = _view.SelectedPlaylist;
            if (playlist == null)
            {
                _view.ShowMessage("Selectați un playlist pentru descarcare.", "Eroare");
                return;
            }

            using(FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        await _model.DownloadPlaylistAsync(playlist.Id, dialog.SelectedPath);
                        _view.ShowMessage("Playlist descarcat cu succes.", "Succes");
                    }
                    catch (Exception ex)
                    {
                        _view.ShowMessage($"Eroare la descarcare: {ex.Message}", "Eroare");
                    }
                }
            }
        }
    }
}
