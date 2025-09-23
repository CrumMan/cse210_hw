using System;
namespace youtube
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();
            Video video1 = new Video();
            video1._author = "Pewdiepie";
            video1._title = "Mincraft But Cursed beyond Cursed!";

            Video video2 = new Video();
            video2._author = "Pewdiepie";
            video2._title = "I CAN'T SPELL MINE!";

            Video video3 = new Video()
            {
                _author = "UNNUS ANNUS",
                _title = "THE CHANNEL HAS BEEN REVIVED!"
            };
            Video video4 = new()
            {
                _author = "Ludwig",
                _title = "I hired someone to cheat to make me not look dumb at Geoguesser!"
            };

            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);
            videos.Add(video4);
            foreach (Video video in videos)
            {
                video.DisplayTitleAuthorAndCommentsNumber();
            }


        }

    }
}