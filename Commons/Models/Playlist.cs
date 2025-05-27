using System;
using System.Collections.Generic;

namespace MediaPlayer.Commons
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<AudioMedia> Media{ get; private set; } = new List<AudioMedia>();

        public void AddMedia(AudioMedia media) => Media.Add(media);
        public void RemoveMedia(AudioMedia media) => Media.Remove(media);
    }
}
