using MediaPlayer.Core.Interfaces;
using MediaPlayer.Core.Models;

namespace MediaPlayer.Core.Strategies
{
    public class RepeatPlaybackStrategy: IPlaybackStrategy
    {
        public AudioMedia GetNextMedia(Playlist playlist, AudioMedia currentMedia) => currentMedia;
    }
}
