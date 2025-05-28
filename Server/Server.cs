using System.Text.Json;
using MediaPlayer.Core.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string uploadRoot = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
if (!Directory.Exists(uploadRoot))
{
    Directory.CreateDirectory(uploadRoot);
}

app.MapPost("/playlist/upload", async (HttpRequest request) =>
{
    if (!request.HasFormContentType)
    {
        return Results.BadRequest("Content type must be multipart/form-data");
    }

    Microsoft.AspNetCore.Http.IFormCollection form = await request.ReadFormAsync();

    if (!form.TryGetValue("playlist", out Microsoft.Extensions.Primitives.StringValues playlistJson))
    {
        return Results.BadRequest("Missing playlist JSON");
    }

    Playlist? playlist = JsonSerializer.Deserialize<Playlist>(playlistJson, new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });

    if (playlist == null)
    {
        return Results.BadRequest("Invalid playlist JSON");
    }

    playlist.Id = Guid.NewGuid();

    string playlistFolder = Path.Combine(uploadRoot, playlist.Id.ToString());

    if (Directory.Exists(playlistFolder))
    {
        Directory.Delete(playlistFolder, true);
    }
    Directory.CreateDirectory(playlistFolder);

    string playlistFilePath = Path.Combine(playlistFolder, "playlist.json");
    string serializedPlaylist = JsonSerializer.Serialize(playlist, new JsonSerializerOptions { WriteIndented = true });
    await File.WriteAllTextAsync(playlistFilePath, serializedPlaylist);

    foreach (Microsoft.AspNetCore.Http.IFormFile file in form.Files)
    {
        string filePath = Path.Combine(playlistFolder, file.FileName);
        using FileStream fs = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(fs);
    }

    return Results.Ok(new { playlistId = playlist.Id });
});

app.MapGet("/playlists", () =>
{
    List<Playlist> playlists = new List<Playlist>();

    if (!Directory.Exists(uploadRoot))
    {
        return Results.Ok(playlists);
    }

    string[] folders = Directory.GetDirectories(uploadRoot);
    foreach (string folder in folders)
    {
        string playlistJsonPath = Path.Combine(folder, "playlist.json");
        if (File.Exists(playlistJsonPath))
        {
            string json = File.ReadAllText(playlistJsonPath);
            Playlist? playlist = JsonSerializer.Deserialize<Playlist>(json);
            if (playlist != null)
            {
                playlists.Add(playlist);
            }
        }
    }

    return Results.Ok(playlists);
});

app.MapGet("/playlists/search", (string q) =>
{
    List<Playlist> playlists = new List<Playlist>();

    if (!Directory.Exists(uploadRoot))
    {
        return Results.Ok(playlists);
    }

    string[] folders = Directory.GetDirectories(uploadRoot);
    foreach (string folder in folders)
    {
        string playlistJsonPath = Path.Combine(folder, "playlist.json");
        if (File.Exists(playlistJsonPath))
        {
            string json = File.ReadAllText(playlistJsonPath);
            Playlist? playlist = JsonSerializer.Deserialize<Playlist>(json);
            if (playlist != null && playlist.Name.Contains(q, StringComparison.OrdinalIgnoreCase))
            {
                playlists.Add(playlist);
            }
        }
    }

    return Results.Ok(playlists);
});

app.MapDelete("/playlists/{id:guid}", (Guid id) =>
{
    string playlistFolder = Path.Combine(uploadRoot, id.ToString());
    if (Directory.Exists(playlistFolder))
    {
        Directory.Delete(playlistFolder, true);
        return Results.Ok();
    }
    else
    {
        return Results.NotFound();
    }
});

app.MapGet("/playlists/{id:guid}/download", async (Guid id, HttpResponse response) =>
{
    string playlistFolder = Path.Combine(uploadRoot, id.ToString());
    if (!Directory.Exists(playlistFolder))
    {
        response.StatusCode = 404;
        await response.WriteAsync("Playlist not found");
        return;
    }

    string tempZipPath = Path.Combine(Path.GetTempPath(), $"{id}.zip");

    if (File.Exists(tempZipPath))
    {
        File.Delete(tempZipPath);
    }

    System.IO.Compression.ZipFile.CreateFromDirectory(playlistFolder, tempZipPath);

    response.ContentType = "application/zip";
    response.Headers.Append("Content-Disposition", $"attachment; filename=\"{id}.zip\"");

    await response.SendFileAsync(tempZipPath);

    File.Delete(tempZipPath);
});

app.Run();
