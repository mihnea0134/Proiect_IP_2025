using MediaPlayer.Core.Models;
using System.Collections.Generic;

namespace MediaPlayer.Core.Interfaces
{
    public interface IView
    {
        void SetPresenter(IPresenter presenter);

        void DisplayPlaylists(List<Playlist> playlists);
        void ShowMessage(string message, string type);
        void ClearPlaylistDisplay();
        void ClearItem(string audioMediaName);
        void ChangePlayButtonText();
        string GetSelectedPlaylistName();
        void DisplayMediaItems(List<AudioMedia> mediaList);
    }
}
