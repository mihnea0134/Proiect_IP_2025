using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_IP_2025
{
    public class MusicModel
    {
        public List<string> Queue { get; } = new List<string>();
        public int CurrentIndex { get; set; } = -1;


        public string CurrentSong
        {
            get
            {
                if (CurrentIndex >= 0 && CurrentIndex < Queue.Count)
                    return Queue[CurrentIndex];
                return null;
            }
        }
        public void AddSong(string path)
        {
            Queue.Add(path);
        }

        public void Next()
        {
            if (Queue.Count > 0)
                CurrentIndex = (CurrentIndex + 1) % Queue.Count;
        }
        public void Previous()
        {
            if (Queue.Count > 0)
                CurrentIndex = (CurrentIndex - 1 + Queue.Count) % Queue.Count;
        }
        public Dictionary<string, List<string>> Playlists { get; } = new Dictionary<string, List<string>>();
        public string CurrentPlaylistName { get; set; } = "Default";

        public void AddPlaylist(string name)
        {
            if (!Playlists.ContainsKey(name))
                Playlists[name] = new List<string>();
        }

        public void AddSongToCurrentPlaylist(string path)
        {
            AddSong(path);
            if (!Playlists.ContainsKey(CurrentPlaylistName))
                Playlists[CurrentPlaylistName] = new List<string>();
            Playlists[CurrentPlaylistName].Add(path);   
        }

        public List<string> GetCurrentPlaylistSongs()
        {
            return Playlists.ContainsKey(CurrentPlaylistName) ? Playlists[CurrentPlaylistName] : new List<string>();
        }

    }
}
