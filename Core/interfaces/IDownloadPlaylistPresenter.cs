using System.Threading.Tasks;

namespace MediaPlayer.Core.Interfaces
{
    public interface IDownloadPlaylistPresenter
    {
        Task SearchPlaylistsAsync();
        Task DownloadSelectedPlaylistAsync();
        void OnPlaylistSelected();
    }
}
