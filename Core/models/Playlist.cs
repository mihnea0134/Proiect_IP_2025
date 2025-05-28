using System;
using System.Collections.Generic;

namespace MediaPlayer.Core.Models
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<AudioMedia> Media { get; private set; } = new List<AudioMedia>();
        public bool WasDownloaded { get; set; }

        public void AddMedia(AudioMedia media) => Media.Add(media);
        public void RemoveMedia(AudioMedia media) => Media.Remove(media);
    }
}