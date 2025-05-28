using System;
using NAudio.Wave;

namespace MediaPlayer.Core.Models
{
    public class AudioMedia
    {
        public string Title { get; set; }
        public string FilePath { get; set; }

        private IWavePlayer _player;
        private AudioFileReader _reader;
        private PlaybackState _playbackState;

        public AudioMedia(string title, string filePath)
        {
            Title = title;
            FilePath = filePath;
            _playbackState = PlaybackState.Stopped;
        }

        public void TogglePlayPause()
        {
            if (_player == null || _player.PlaybackState == PlaybackState.Stopped)
            {
                Play();
            }
            else if (_player.PlaybackState == PlaybackState.Playing)
            {
                Pause();
            }
            else if (_player.PlaybackState == PlaybackState.Paused)
            {
                _player.Play();
            }
        }

        public void Play()
        {
            if (_player == null)
            {
                _reader = new AudioFileReader(FilePath);
                _player = new WaveOutEvent();
                _player.Init(_reader);
            }
            _player.Play();
        }

        public void Pause()
        {
            _player.Pause();
        }

        public void Stop()
        {
            if (_player != null)
            {
                _player.Stop();
                _reader.Position = 0;
                _player.Dispose();
                _reader.Dispose();
                _player = null;
                _reader = null;
            }
        }
    }
}