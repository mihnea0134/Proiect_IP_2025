using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaPlayer.Core.Interfaces
{
    public interface ICreatePlaylistPresenter
    {
        Dictionary<string, DialogResult> OnClickCreatePlaylist();
        string OnClickAddMediaToPlaylist(List<string> selectedMedia);
    }
}
