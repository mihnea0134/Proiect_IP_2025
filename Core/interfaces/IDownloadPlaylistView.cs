using MediaPlayer.Core.Models;
using System.Collections.Generic;

namespace MediaPlayer.Core.Interfaces
{
    public interface IDownloadPlaylistView
    {
        void ShowMessage(string message, string title);
        void CloseView();
        string FilterText { get; }
        Playlist SelectedPlaylist { get; }
        void SetPlaylists(List<Playlist> playlists);
        void SetMedia(List<string> songs);
    }
}
