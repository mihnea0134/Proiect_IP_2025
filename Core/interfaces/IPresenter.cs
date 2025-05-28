using System.Collections.Generic;

namespace MediaPlayer.Core.Interfaces
{
    public interface IPresenter
    {
        void LoadAllPlaylists();
        void CreateNewPlaylist(string name, List<string> filePaths);
        void DeleteSelectedPlaylist();
        void DeleteSelectedAudioMedia(string playlistName, string audioMediaName);
        void DownloadOnlinePlaylists();
        void UploadOrDeleteOnlinePlaylist();
        void PlaylistSelected(string playlistName);
        void SetPlaybackStrategy(IPlaybackStrategy strategy);
        void LoadMedia();
        void PlayAndPause();
        void VolumeChanged(int volume);
        void SeekChanged(int position);
    }
}
