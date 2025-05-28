using MediaPlayer.Core.Interfaces;
using MediaPlayer.Core.Models;

namespace MediaPlayer.Core.Player
{
    public class MediaPlayer
    {
        private IPlaybackStrategy _strategy;

        public Playlist CurrentPlaylist { get; set; }
        public AudioMedia CurrentAudioMedia { get; private set; }

        public void SetPlaybackStrategy(IPlaybackStrategy strategy) => _strategy = strategy;

        public void PlayNext()
        {
            if (_strategy == null || CurrentPlaylist == null || CurrentAudioMedia == null)
            {
                return;
            }

            AudioMedia nextAudioMedia = _strategy.GetNextMedia(CurrentPlaylist, CurrentAudioMedia);

            if (nextAudioMedia != null)
            {
                CurrentAudioMedia = nextAudioMedia;
                CurrentAudioMedia.Play();
            }
        }
    }
}
