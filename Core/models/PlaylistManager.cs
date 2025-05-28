using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
 
namespace MediaPlayer.Core.Models
{
    public sealed class PlaylistManager
    {
        private static readonly PlaylistManager _instance = new PlaylistManager();
        private readonly Dictionary<string, Playlist> _playlists = new Dictionary<string, Playlist>();
        private const string _StoragePath = "playlists.json";

        private PlaylistManager() 
        {
            LoadFromDisk();
        }

        public static PlaylistManager PlaylistManagerInstance => _instance;

        public string AddPlaylist(Playlist playlist)
        {
            if (playlist == null)
            {
                return null;
            }

            string baseName;

            baseName = string.IsNullOrWhiteSpace(playlist.Name) ? "Playlist" : playlist.Name;
            string finalName = baseName;
            int suffix = 1;

            while(_playlists.ContainsKey(finalName))
            {
                finalName = $"{baseName}({suffix})";
                ++suffix;
            }

            playlist.Name = finalName;
            _playlists[finalName] = playlist;

            string errorMessage = SaveToDisk();
            if (errorMessage != "")
            {
                throw new Exception(errorMessage);
            }

            return finalName;
        }

        public Playlist GetPlaylist(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return _playlists.TryGetValue(name, out var p) ? p : null;
            }
            else
            {
                return null;
            }
        }

        public void RemovePlaylist(string name)
        {
            if (!string.IsNullOrWhiteSpace(name) && _playlists.Remove(name))
            {
                string errorMessage = SaveToDisk();
                if(errorMessage != "")
                {
                    throw new Exception(errorMessage);
                }
            }
        }

        public IEnumerable<Playlist> GetAll() => _playlists.Values;

        private string SaveToDisk()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };

            string json = JsonSerializer.Serialize(_playlists.Values, options);

            try
            {
                File.WriteAllText(_StoragePath, json);
            }
            catch (ArgumentNullException)
            {
                return "Calea sau continutul este null.";
            }
            catch (PathTooLongException)
            {
                return "Calea specificata este prea lunga.";
            }
            catch (DirectoryNotFoundException)
            {
                return "Directorul specificat nu a fost gasit.";
            }
            catch (IOException)
            {
                return "A aparut o eroare de intrare/iesire la scrierea fisierului.";
            }
            catch (NotSupportedException)
            {
                return "Formatul caii specificate nu este suportat.";
            }
            catch (UnauthorizedAccessException)
            {
                return "Accesul la fisier a fost refuzat.";
            }
            catch (System.Security.SecurityException)
            {
                return "Nu ai permisiuni suficiente pentru a accesa acest fisier.";
            }

            return "";
        }

        private string LoadFromDisk()
        {
            if (!File.Exists(_StoragePath))
            {
                return "Fisierul nu exista.";
            }

            string json;

            try
            { 
                json = File.ReadAllText(_StoragePath);
            }
            catch (ArgumentNullException)
            {
                return "Calea sau continutul este null.";
            }
            catch (PathTooLongException)
            {
                return "Calea specificata este prea lunga.";
            }
            catch (DirectoryNotFoundException)
            {
                return "Directorul specificat nu a fost gasit.";
            }
            catch (IOException)
            {
                return "A aparut o eroare de intrare/iesire la citirea fisierului.";
            }
            catch (NotSupportedException)
            {
                return "Formatul caii specificate nu este suportat.";
            }
            catch (UnauthorizedAccessException)
            {
                return "Accesul la fisier a fost refuzat.";
            }
            catch (System.Security.SecurityException)
            {
                return "Nu ai permisiuni suficiente pentru a accesa acest fisier.";
            }

            List<Playlist> loadedPlaylists = JsonSerializer.Deserialize<List<Playlist>>(json);

            _playlists.Clear();
            if (loadedPlaylists != null)
            {
                foreach (Playlist p in loadedPlaylists)
                {
                    _playlists[p.Name] = p;
                }
            }

            return "";
        }
    }
}
