using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        // From class video create a new instace
        List<Video> videos = new List<Video>();

        // Instance's is the realization of attributes and methods in the computer's memory
        Video video1 = new Video("Looking through windows", "The Church of Jesus Christ of Latter-day Saints", 140);

        video1.AddComment(new Comment("@KateK-yx3fq", "Wow this is a very impactful illustration!!!! I am Catholic but I am very much enjoying and appreciate these messages. They are very well done! Thank you for ministering to others through these. "));
        video1.AddComment(new Comment("@uannyena", "Thank you so much for putting up closed captioned for a Deaf person like me. The message is AWESOME and INSPIRATIONAL! Thank you!"));
        video1.AddComment(new Comment("@keithchristensen4884", "I know it.  I'll try harder to remember it.  Loved the reminder - gently and beautifully done President Monson. "));
        video1.AddComment(new Comment("@LindsayCatherine", "I am a Christian and I like this message! Thank you so much for posting your comment! It glorifies the message of the video all the more!"));
        videos.Add(video1);

        // Instance N.2
        Video video2 = new Video("Beethoven - Moonlight Sonata ", "andrea romano", 900);

        video2.AddComment(new Comment("@criss", "The most beautiful work of the heart ever composed."));
        video2.AddComment(new Comment("@kristiehuckaby7833", "He was the best on the piano"));
        video2.AddComment(new Comment("@LimitlessJohn8937", "I AM ATOMIC"));
        video2.AddComment(new Comment("@LeiannVillas", "It's so colll to learn thiss"));
        videos.Add(video2);

        // Instance N.3
        Video video3 = new Video("Back To Black", "Amy Winehouse", 240);

        video3.AddComment(new Comment("@guillermo", "The world is missing you."));
        video3.AddComment(new Comment("@ReinaWilliams", "This song just reminded me of how much I'm in love with music. ❤"));
        video3.AddComment(new Comment("@orichinal.", "This music is timeless. The magnitude of talent she had is incredible."));
        video3.AddComment(new Comment("@bonesjr83", "Celebrating her life on the anniversary of her passing. Gone but not forgotten. RIP Amy"));
        videos.Add(video3);

        // Display videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"lenght in sec: {video._duration}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine($"Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._user}: {comment._commentText}");
            }
            Console.WriteLine();
        }

    }
}