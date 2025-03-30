
using System.Runtime.Intrinsics;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video v1 = new Video("Can I hold my breath for 10 minuts?", "Johnny Dope", 600);
        Video v2 = new Video("Test driving a Tesla Roadster", "Tonald Drump", 720);
        Video v3 = new Video("Best street food in Taiwan", "Shawn Mendez", 1200);
        Video v4 = new Video("Why does a lemon float?", "Mark Rober", 3000);

        v1.AddComment(new Comment("Jonny", "Haha, great video!"));
        v1.AddComment(new Comment("Angela", "Wow, that a long time to hold your breath!"));
        v1.AddComment(new Comment("George", "I bet I could hold mine longer"));
        v1.AddComment(new Comment("Brown", "Some people have too much time on their hands"));

        v2.AddComment(new Comment("Shawn", "Sure is a fancy car"));
        v2.AddComment(new Comment("Jerry", "Wow that's some crazy acceleration!"));
        v2.AddComment(new Comment("Greg", "Personally I still prefer my Ferrari"));
        v2.AddComment(new Comment("Grace", "Bu how far can it go on a single charge?"));

        v3.AddComment(new Comment("Angelica", "Dang! that looks soooo yummy!"));
        v3.AddComment(new Comment("May", "Yeah... I don't trust street food."));
        v3.AddComment(new Comment("West", "Any diseases from that?"));
        v3.AddComment(new Comment("Jordan", "My personal favorit are their green onion pancakes"));

        v4.AddComment(new Comment("Tommy", " Wow you really turned a dumb question into a great video!"));
        v4.AddComment(new Comment("Brittany", "I can't believe there is so much science behind something so simple."));
        v4.AddComment(new Comment("Todd", "Loved the video, always so prefessional."));
        v4.AddComment(new Comment("Savanah", "Okay, but whay does a potato float?"));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

        Console.Clear();
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine($"Number of comments: {video.GetCommmentCount()}");
            Console.WriteLine();
            foreach (Comment comment in video.GetComments())
            {
                comment.Display();
            }
            Console.WriteLine("\n");
        }
    }
}