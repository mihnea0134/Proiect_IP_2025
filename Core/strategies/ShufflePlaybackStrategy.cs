using MediaPlayer.Core.Interfaces;
using MediaPlayer.Core.Models;
using System;

namespace MediaPlayer.Core.Strategies
{
    public class ShufflePlaybackStrategy: IPlaybackStrategy
    {
        private Random _random = new Random();
        public AudioMedia GetNextMedia(Playlist playlist, AudioMedia currentMedia)
        {
            if (playlist.Media.Count == 0)
            {
                return null;
            }

            AudioMedia nextMedia;

            do
            {
                nextMedia = playlist.Media[_random.Next(playlist.Media.Count)];
            } while (nextMedia == currentMedia && playlist.Media.Count > 1);


            return nextMedia;
        }
    }
}
