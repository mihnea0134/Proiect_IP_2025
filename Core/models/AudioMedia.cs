namespace MediaPlayer.Core.Models
{
    public class AudioMedia
    {
        public string Title { get; set; }
        public string FilePath { get; set; }

        public AudioMedia(string title, string filePath)
        {
            Title = title;
            FilePath = filePath;
        }

        public void Play()
        {

        }
    }
}