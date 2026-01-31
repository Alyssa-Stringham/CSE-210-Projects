using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        
        List<Video> _videos = new List<Video>();

        Video video1 = new Video();
        video1.SetVideoValues("Simon Adams", "How to Make a YouTube Video", 320);
        Comments v1Comment1 = new Comments();
        v1Comment1.SetComment("Sara Jones", "What a helpful video!");
        Comments v1Comment2 = new Comments();
        v1Comment2.SetComment("Jason James", "Thanks for the video."); 
        Comments v1Comment3 = new Comments();
        v1Comment3.SetComment("Mary Abbot", "Great video!");               
        video1._comments.Add(v1Comment1);
        video1._comments.Add(v1Comment2);
        video1._comments.Add(v1Comment3);
        _videos.Add(video1);


        Video video2 = new Video();
        video2.SetVideoValues("Paul Evans", "Best Movies of 2025", 750);
        Comments v2Comment1 = new Comments();
        v2Comment1.SetComment("Alan Ellis", "Completely Agree!");
        Comments v2Comment2 = new Comments();
        v2Comment2.SetComment("Amy Smith", "You should do a video on TV shows next");
        Comments v2Comment3 = new Comments();
        v2Comment3.SetComment("Sam Roberts", "Thanks for the video, helped me decide what to watch this weekend!");
        video2._comments.Add(v2Comment1);
        video2._comments.Add(v2Comment2);
        video2._comments.Add(v2Comment3);
        _videos.Add(video2);


        Video video3 = new Video();
        video3.SetVideoValues("Martha Parker", "Everything You Need to Know About Internet Safety in 7 Minutes", 415);
        Comments v3Comment1 = new Comments();
        v3Comment1.SetComment("Emily Bible", "Great video, everyone should watch. ");
        Comments v3Comment2 = new Comments();
        v3Comment2.SetComment("Jane Taylor", "You should give more details about how to avoid specific scams.");
        Comments v3Comment3 = new Comments();
        v3Comment3.SetComment("Peter Douglass", "Wish I had seen this video a couple years ago! Would have saved me some trouble. ");
        Comments v3Comment4 = new Comments();
        v3Comment4.SetComment("John Paul", "Pretty basic information...");
        video3._comments.Add(v3Comment1);
        video3._comments.Add(v3Comment2);
        video3._comments.Add(v3Comment3);
        video3._comments.Add(v3Comment4);
        _videos.Add(video3);


        foreach (Video video in _videos)
        {
            video.DisplayVideo();    
        }
    }
}