using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO.Compression;

namespace MediaPlayer.Core.Models
{
    public class ServerService
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public ServerService(string baseUrl)
        {
            _baseUrl = baseUrl.TrimEnd('/');
            _client = new HttpClient();
        }

        public async Task UploadPlaylistAsync(Playlist playlist, List<string> filePaths)
        {
            playlist.WasDownloaded = true;
            MultipartFormDataContent content = new MultipartFormDataContent();

            string playlistJson = JsonSerializer.Serialize(playlist);
            content.Add(new StringContent(playlistJson), "playlist");

            foreach (string path in filePaths)
            {
                FileStream stream = File.OpenRead(path);
                StreamContent streamContent = new StreamContent(stream);
                streamContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                content.Add(streamContent, "files", Path.GetFileName(path));
            }

            HttpResponseMessage response = await _client.PostAsync($"{_baseUrl}/playlist/upload", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeletePlaylistAsync(Guid playlistId)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"{_baseUrl}/playlists/{playlistId}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<List<Playlist>> GetAllPlaylistsAsync()
        {
            HttpResponseMessage response = await _client.GetAsync($"{_baseUrl}/playlists");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Playlist>>(json) ?? new List<Playlist>();
        }

        public async Task<List<Playlist>> SearchPlaylistsAsync(string query)
        {
            HttpResponseMessage response = await _client.GetAsync($"{_baseUrl}/playlists/search?q={Uri.EscapeDataString(query)}");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Playlist>>(json) ?? new List<Playlist>();
        }

        public async Task<Playlist> DownloadPlaylistAsync(Guid playlistId, string targetFolder)
        {
            Directory.CreateDirectory(targetFolder);

            HttpResponseMessage response = await _client.GetAsync($"{_baseUrl}/playlists/{playlistId}/download");
            response.EnsureSuccessStatusCode();

            string tempZipPath = Path.Combine(Path.GetTempPath(), $"{playlistId}.zip");
            using (FileStream fs = new FileStream(tempZipPath, FileMode.Create, FileAccess.Write))
            {
                await response.Content.CopyToAsync(fs);
            }

            if (Directory.Exists(targetFolder))
            {
                Directory.Delete(targetFolder, true);
            }

            ZipFile.ExtractToDirectory(tempZipPath, targetFolder);

            string playlistJsonPath = Path.Combine(targetFolder, "playlist.json");
            string json = File.ReadAllText(playlistJsonPath);

            return JsonSerializer.Deserialize<Playlist>(json) ?? throw new Exception("Failed to parse playlist.json");
        }
    }
}
