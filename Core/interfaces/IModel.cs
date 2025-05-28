using MediaPlayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediaPlayer.Core.Interfaces
{
    public interface IModel
    {
        // Pentru modelul ce se ocupa de fisiere locale

        string AddPlaylistLocal(Playlist playlist);
        Playlist GetPlaylistLocal(string name);
        void RemovePlaylistLocal(string name);
        void RemoveAudioMediaLocal(string playlistName, string audioMediaName);
        IEnumerable<Playlist> GetAllLocal();

        // Pentru modelul ce se ocupa de fisiere de pe server

        Task UploadPlaylistAsync(Playlist playlist, List<string> filePaths);
        Task DeletePlaylistAsync(Guid playlistId);
        Task<List<Playlist>> GetAllPlaylistsAsync();
        Task<List<Playlist>> SearchPlaylistsAsync(string query);
        Task<Playlist> DownloadPlaylistAsync(Guid playlistId, string targetFolder);
    }
}
