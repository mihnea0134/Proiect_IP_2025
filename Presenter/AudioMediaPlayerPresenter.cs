using MediaPlayer.Core.Interfaces;
using MediaPlayer.Core.Models;
using MediaPlayer.Core.Player;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;


namespace MediaPlayer.Presenter
{
    public class AudioMediaPlayerPresenter: IPresenter
    {
        private readonly IView _view;
        private readonly IModel _model;
        private readonly MediaPlayerSetter _mediaPlayer = new MediaPlayerSetter();
        private int _currentMediaIndex = 0;
        private Playlist _currentPlaylist;
        private bool _isPlaying = false;

        public AudioMediaPlayerPresenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
        }

        public void CreateNewPlaylist(string playlistName, List<string> mediaFilesPaths)
        {
            Playlist playlist = new Playlist
            {
                Id = Guid.NewGuid(),
                Name = playlistName
            };

            foreach(string path in mediaFilesPaths)
            {
                string title = Path.GetFileNameWithoutExtension(path);
                playlist.AddMedia(new AudioMedia(title, path));
            }

            _model.AddPlaylistLocal(playlist);
            _view.DisplayPlaylists(_model.GetAllLocal().ToList());
        }

        public void DeleteSelectedAudioMedia(string playlistName, string audioMediaName)
        {
            if (string.IsNullOrEmpty(playlistName) || string.IsNullOrEmpty(audioMediaName))
            {
                _view.ShowMessage("Niciun audio media selectat.", "Eroare");
                return;
            }

            _model.RemoveAudioMediaLocal(playlistName, audioMediaName);
            LoadAllPlaylists();
            _view.ClearItem(audioMediaName);
        }

        public void LoadAllPlaylists()
        {
            List<Playlist> playlists = _model.GetAllLocal().ToList();
            _view.DisplayPlaylists(playlists);
        }

        public void DeleteSelectedPlaylist()
        {
            string name = _view.GetSelectedPlaylistName();
            if (string.IsNullOrEmpty(name))
            {
                _view.ShowMessage("Niciun playlist selectat.", "Eroare");
                return;
            }

            _model.RemovePlaylistLocal(name);
            LoadAllPlaylists();
            _view.ClearPlaylistDisplay();
        }

        public async void DownloadOnlinePlaylists()
        {
            try
            {
                List<Playlist> playlists = await _model.GetAllPlaylistsAsync();
            }
            catch (Exception)
            {
                _view.ShowMessage("Nu s-au putut descarca playlist-urile.", "Eroare");
            }
        }

        public void UploadOrDeleteOnlinePlaylist()
        {

        }

        public void PlaylistSelected(string playlistName)
        {
            if (string.IsNullOrEmpty(playlistName))
            {
                return;
            }

            _currentPlaylist = _model.GetPlaylistLocal(playlistName);
            _currentMediaIndex = 0;

            if (_currentPlaylist != null)
            {
                _view.DisplayMediaItems(_currentPlaylist.Media);
                _mediaPlayer.CurrentPlaylist = _currentPlaylist;
            }
        }

        public void SetPlaybackStrategy(IPlaybackStrategy strategy)
        {
            _mediaPlayer.SetPlaybackStrategy(strategy);
        }

        public void LoadMedia()
        {
            if (_currentPlaylist == null || !_currentPlaylist.Media.Any())
            {
                _view.ShowMessage("Nu aveti media pe care sa o redati.", "Eroare");
                return;
            }

            AudioMedia media = _currentPlaylist.Media[_currentMediaIndex];
        }

        public void PlayAndPause()
        {
            if (!_isPlaying)
            {
                if (_mediaPlayer.CurrentAudioMedia == null)
                {
                    _view.ShowMessage("Niciun media selectat pentru redare.", "Eroare");
                    return;
                }

                _mediaPlayer.CurrentAudioMedia.Play();
                _isPlaying = true;
                _view.ChangePlayButtonText();
            }
            else
            {
                _isPlaying = false;
                _view.ChangePlayButtonText();
                _mediaPlayer.CurrentAudioMedia.Pause();
            }
        }

        public void VolumeChanged(int volume)
        {

        }

        public void SeekChanged(int position)
        {

        }
    }
}
