namespace MediaPlayer.Commons
{
    public class AudioMedia
    {
        public string Title { get; private set; }
        public string FilePath { get; private set; }

        public AudioMedia(string title, string filePath)
        {
            Title = title;
            FilePath = filePath;
        }
    }
}
