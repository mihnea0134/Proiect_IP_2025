using MediaPlayer.Core.Interfaces;
using MediaPlayer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace MediaPlayer.Model
{
    public class PlaylistRepository: IModel
    {
        private readonly PlaylistManager _playlistManager;
        private readonly ServerService _serverService;

        public PlaylistRepository(PlaylistManager playlistManager, ServerService serverService)
        {
            _playlistManager = playlistManager;
            _serverService = serverService;
        }

        // Pentru modelul ce se ocupa de fisiere locale

        public string AddPlaylistLocal(Playlist playlist) => _playlistManager.AddPlaylist(playlist);
        public Playlist GetPlaylistLocal(string name) => _playlistManager.GetPlaylist(name);
        public void RemovePlaylistLocal(string name) => _playlistManager.RemovePlaylist(name);
        public IEnumerable<Playlist> GetAllLocal() => _playlistManager.GetAll();

        // Pentru modelul ce se ocupa de fisiere de pe server

        public Task UploadPlaylistAsync(Playlist playlist, List<string> filePaths) => _serverService.UploadPlaylistAsync(playlist, filePaths);
        public Task DeletePlaylistAsync(Guid playlistId) => _serverService.DeletePlaylistAsync(playlistId);
        public Task<List<Playlist>> GetAllPlaylistsAsync() => _serverService.GetAllPlaylistsAsync();
        public Task<List<Playlist>> SearchPlaylistsAsync(string query) => _serverService.SearchPlaylistsAsync(query);
        public Task<Playlist> DownloadPlaylistAsync(Guid playlistId, string targetFolder) => _serverService.DownloadPlaylistAsync(playlistId, targetFolder);
    }
}
