//class Program
//{
//    static void Main()
//    {
//        // Создаем объект AdvancedMediaPlayer
//        AdvancedMediaPlayer advancedMediaPlayer = new AdvancedMediaPlayer();

//        // Создаем адаптер, который использует AdvancedMediaPlayer
//        IMediaPlayer mediaPlayer = new MediaPlayerAdapter(advancedMediaPlayer);

//        // Используем адаптер через интерфейс IMediaPlayer
//        mediaPlayer.Play("mp3");
//        mediaPlayer.Play("mp4");
//        mediaPlayer.Play("mp5");
//    }
//}
//interface IMediaPlayer
//{
//    void Play(string audioType);
//}

//// Сторонний класс, который мы хотим адаптировать
//class AdvancedMediaPlayer
//{
//    public void PlayMp3()
//    {
//        Console.WriteLine("Playing MP3 file");
//    }

//    public void PlayMp4()
//    {
//        Console.WriteLine("Playing MP4 file");
//    }
//}

//// Адаптер, который реализует интерфейс IMediaPlayer и использует AdvancedMediaPlayer
//class MediaPlayerAdapter : IMediaPlayer
//{
//    private AdvancedMediaPlayer advancedMediaPlayer;

//    public MediaPlayerAdapter(AdvancedMediaPlayer advancedMediaPlayer)
//    {
//        this.advancedMediaPlayer = advancedMediaPlayer;
//    }

//    public void Play(string audioType)
//    {
//        if (audioType == "mp4")
//        {
//            advancedMediaPlayer.PlayMp4();
//        }
//        else if (audioType == "mp3")
//        {
//            advancedMediaPlayer.PlayMp3();
//        }
//        else
//        {
//            Console.WriteLine("Wrong Media type ");
//        }
//    }
//}

