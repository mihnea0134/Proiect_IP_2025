using NAudio.Wave;
using Proiect_IP_2025;
using System;
using System.Windows.Forms;

namespace Proiect_IP_2025.Controller
{
    public class MusicController
    {
        private readonly MusicModel model;
        private readonly ListBox queueList;
        private readonly Label songLabel;
        private readonly Label artistLabel;

        private IWavePlayer outputDevice;
        private AudioFileReader audioFile;

        public MusicController(MusicModel model, ListBox queueList, Label songLabel, Label artistLabel)
        {
            this.model = model;
            this.queueList = queueList;
            this.songLabel = songLabel;
            this.artistLabel = artistLabel;
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

                songLabel.Text = System.IO.Path.GetFileNameWithoutExtension(song);
                artistLabel.Text = "Unknown Artist"; // simplificare
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
                model.CurrentIndex = index;
                PlayCurrent();
            }
        }

        public void Stop()
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            outputDevice = null;

            audioFile?.Dispose();
            audioFile = null;
        }
    }
}
