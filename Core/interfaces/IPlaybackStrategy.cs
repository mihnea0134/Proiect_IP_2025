using MediaPlayer.Core.Models;

namespace MediaPlayer.Core.Interfaces
{
    public interface IPlaybackStrategy
    {
        AudioMedia GetNextMedia(Playlist playlist, AudioMedia currentMedia);
    }
}
