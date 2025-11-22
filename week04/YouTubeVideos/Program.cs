using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video()
        {
            Title = "How to make slime",
            Author = "Sabrina Carpenter",
            LengthSeconds = 500
        };

        v1.AddComment(new Comment("Rocio", "Thank you, nice video!"));
        v1.AddComment(new Comment("Veronica", "It worked, amazing video"));
        v1.AddComment(new Comment("Alexis", "It is a lost of time, too much ingredients."));
        videos.Add(v1);

        Video v2 = new Video()
        {
            Title = "Learn how to do an origami frog",
            Author = "Paola Smith",
            LengthSeconds = 258
        };
            
        v2.AddComment(new Comment("Camila", "So easy, my son love it!"));
        v2.AddComment(new Comment("Lisa", "I love it"));
        v2.AddComment(new Comment("Roberto", "It is perfect for my art class."));
        videos.Add(v2);

        Video v3 = new Video()
        {
            Title = "5 little steps to change your life.",
            Author = "Mike P.",
            LengthSeconds = 752
        };
            
        v3.AddComment(new Comment("Max", "The best video"));
        v3.AddComment(new Comment("Jose", "I will do it, to change my life."));
        v3.AddComment(new Comment("Ivan", "I think this does not work."));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($" - {c.CommenterName}: {c.Text}");
            }

            Console.WriteLine();
        }
    }
}