using MediaPlayer.Core.Interfaces;
using MediaPlayer.Core.Models;

namespace MediaPlayer.Core.Strategies
{
    public class SequencialPlaybackStrategy: IPlaybackStrategy
    {
        public AudioMedia GetNextMedia(Playlist playlist, AudioMedia currentMedia)
        {
            int currentMediaIndex = playlist.Media.IndexOf(currentMedia);

            if (currentMediaIndex == -1 || currentMediaIndex + 1 >= playlist.Media.Count)
            {
                return null;
            }

            return playlist.Media[currentMediaIndex + 1];
        }
    }
}
