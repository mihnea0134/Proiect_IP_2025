using System.Collections.Generic;

namespace MediaPlayer.Core.Interfaces
{
    public interface ICreatePlaylistView
    {
        string PlaylistNameInput { get; }
        void SetSelectedFiles();
        void ShowMessage(string message, string type);
        void CloseView();
    }
}
