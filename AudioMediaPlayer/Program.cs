using MediaPlayer.Core.Interfaces;
using MediaPlayer.Presenter;
using MediaPlayer.Core.Models;
using MediaPlayer.Model;
using MediaPlayer.View;

namespace MediaPlayer
{
    static class Program
    {
        static void Main()
        {
            IModel model = new PlaylistRepository(PlaylistManager.PlaylistManagerInstance, new ServerService(@"C:\Users\cosmi\Proiect_IP_2025\Server\bin\Debug\net8.0\Uploads)"));

            IView view = new FormAudioMediaPlayer();
            IPresenter presenter = new MediaPlayerPresenter(view, model);

            view.SetPresenter(presenter);
            ((FormAudioMediaPlayer)view).SetModel(model);
            ((FormAudioMediaPlayer)view).ShowDialog();
        }
    }
}
