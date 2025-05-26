using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_IP_2025
{
    public class MusicModel
    {
        public List<string> Playlist { get; } = new List<string>();
        public int CurrentIndex { get; set; } = -1;


        public string CurrentSong
        {
            get
            {
                if (CurrentIndex >= 0 && CurrentIndex < Playlist.Count)
                    return Playlist[CurrentIndex];
                return null;
            }
        }
        public void AddSong(string path)
        {
            Playlist.Add(path);
        }

        public void Next()
        {
            if (Playlist.Count > 0)
                CurrentIndex = (CurrentIndex + 1) % Playlist.Count;
        }
        public void Previous()
        {
            if (Playlist.Count > 0)
                CurrentIndex = (CurrentIndex - 1 + Playlist.Count) % Playlist.Count;
        }
    }
}
