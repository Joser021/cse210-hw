using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How running everyday has helped me", "Bob Will", 600);
        Video video2 = new Video("Python Course #01 - Be a Programmer", "Gustavo Guanabara", 1747);
        Video video3 = new Video("Learn how to cook Cookies", "Cooking for Learning", 330);

        video1._comments.Add(new Comment("Alan", "Thank you so much, you motived me to start running"));
        video1._comments.Add(new Comment("Anna", "I've been running for 5 year now, it was the best decision ever!!"));
        video1._comments.Add(new Comment("Astolfo", "I started running many times, it's hard for me. but I'm confident this time"));

        video2._comments.Add(new Comment("Brenda", "You teach very well, I finnaly understand "));
        video2._comments.Add(new Comment("Brandon", "I'm always wondered that I could be a programmer"));
        video2._comments.Add(new Comment("Bryce", "I sounds a little challenging,  and I like challenges"));

        video3._comments.Add(new Comment("Carl", "wow, those cookies looks like so yummy"));
        video3._comments.Add(new Comment("Charlotte", "My kids ask for cookies all the time, I will try this recipe"));
        video3._comments.Add(new Comment("Case", "I want Cookieeeees!!"));

        List<Video> videosList = new List<Video> { video1, video2, video3 };

        foreach (Video video in videosList)
        {
            Console.WriteLine("VIDEO INFORMATIONS:");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} segundos");
            Console.WriteLine($"Number of comments: {video.GetCommentsLength()}");

            Console.WriteLine();
            Console.WriteLine("COMMENTS:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._commenter}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}