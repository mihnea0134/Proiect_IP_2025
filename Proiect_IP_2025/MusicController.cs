using NAudio.Wave;
using Proiect_IP_2025;
using System;
using System.Linq;
using System.Windows.Forms;
using TagLib;
using System.Drawing;
using System.IO;   
namespace Proiect_IP_2025.Controller
{
    public class MusicController
    {
        private readonly MusicModel model;
        private readonly ListBox queueList;
        private readonly Label songLabel;
        private readonly Label artistLabel;
        private readonly TrackBar volumeBar;

        private readonly TrackBar positionBar;
        private readonly Label timeLabel;
        private System.Windows.Forms.Timer progressTimer;
        private bool isUserSeeking = false;


        private IWavePlayer outputDevice;
        private AudioFileReader audioFile;
        private readonly PictureBox albumArtBox; 

        public MusicController(MusicModel model, ListBox queueList, Label songLabel,
                               Label artistLabel, PictureBox albumArtBox, TrackBar volumeBar, TrackBar positionBar, Label timeLabel)
        {
            this.model = model;
            this.queueList = queueList;
            this.songLabel = songLabel;
            this.artistLabel = artistLabel;
            this.albumArtBox = albumArtBox;
            this.volumeBar = volumeBar;
            this.positionBar = positionBar;
            this.timeLabel = timeLabel;
            // Initialize timer for progress updates
            progressTimer = new Timer { Interval = 250 }; // Update every 250ms
            progressTimer.Tick += UpdateProgress;

            // Handle user seeking
            positionBar.Scroll += (s, e) => {
                if (audioFile != null && !isUserSeeking)
                {
                    isUserSeeking = true;
                    audioFile.CurrentTime = TimeSpan.FromSeconds(positionBar.Value);
                    isUserSeeking = false;
                }
            };
        }


        private void UpdateProgress(object sender, EventArgs e)
        {
            if (audioFile == null || isUserSeeking) return;

            // Update trackbar max duration (if song length changes)
            if (positionBar.Maximum != (int)audioFile.TotalTime.TotalSeconds)
                positionBar.Maximum = (int)audioFile.TotalTime.TotalSeconds;

            // Update current position
            positionBar.Value = (int)audioFile.CurrentTime.TotalSeconds;

            // Update time label (e.g., "0:32 / 3:45")
            timeLabel.Text = $"{audioFile.CurrentTime:mm\\:ss} / {audioFile.TotalTime:mm\\:ss}";

            if (audioFile.CurrentTime.TotalSeconds >= audioFile.TotalTime.TotalSeconds - 0.1)
            {
                Next(); // Auto-play next song when current ends
            }

        }

        public void AddSong()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "MP3 files|*.mp3",
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in ofd.FileNames)
                {
                    model.AddSong(file);
                    queueList.Items.Add(System.IO.Path.GetFileName(file));
                }

                if (model.CurrentIndex == -1 && model.Playlist.Count > 0)
                {
                    model.CurrentIndex = 0;
                    PlayCurrent();
                }
            }
        }

        public void PlayCurrent()
        {
            Stop(); // Stop current playback

            var song = model.CurrentSong;
            if (song != null)
            {
                audioFile = new AudioFileReader(song);

                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
                // Extract metadata using TagLib
                var file = TagLib.File.Create(song);
                songLabel.Text = file.Tag.Title ?? System.IO.Path.GetFileNameWithoutExtension(song);
                artistLabel.Text = file.Tag.FirstPerformer ?? "Unknown Artist";

                // Handle album art
                if (file.Tag.Pictures.Length > 0)
                {
                    var picture = file.Tag.Pictures[0];
                    using (var ms = new System.IO.MemoryStream(picture.Data.Data))
                    {
                        var image = Image.FromStream(ms);
                        // We need to invoke this on the UI thread
                        songLabel.Invoke((MethodInvoker)delegate {
                            songLabel.Parent.Controls.OfType<PictureBox>().First().Image = image;
                        });
                    }
                }
                else
                {
                    // Clear the pictureBox if no image found
                    songLabel.Invoke((MethodInvoker)delegate {
                        songLabel.Parent.Controls.OfType<PictureBox>().First().Image = null;
                    });
                }
                songLabel.Text = System.IO.Path.GetFileNameWithoutExtension(song);
                artistLabel.Text = "Unknown Artist"; // simplificare
                                                     // Initialize position bar
                positionBar.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                positionBar.Value = 0;
                progressTimer.Start(); // Start updating progress
                queueList.SelectedIndex = model.CurrentIndex;
            }
        }

        public void PlayPause()
        {
            if (outputDevice == null) return;

            if (outputDevice.PlaybackState == PlaybackState.Playing)
                outputDevice.Pause();
            else if (outputDevice.PlaybackState == PlaybackState.Paused)
                outputDevice.Play();
        }

        public void Next()
        {
            model.Next();
            PlayCurrent();
        }

        public void Previous()
        {
            model.Previous();
            PlayCurrent();
        }

        public void SetVolume(float volume) // volume 0.0f - 1.0f
        {
            if (audioFile != null)
                audioFile.Volume = volume;
        }

        public void SelectSong(int index)
        {
            if (index >= 0 && index < model.Playlist.Count)
            {
                // Only restart if it's a NEW song selection
                if (model.CurrentIndex != index || outputDevice?.PlaybackState != PlaybackState.Playing)
                {
                    model.CurrentIndex = index;
                    PlayCurrent();
                }
            }
        }

        public void Stop()
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            outputDevice = null;
            progressTimer.Stop();
            audioFile?.Dispose();
            audioFile = null;
        }
    }
}
