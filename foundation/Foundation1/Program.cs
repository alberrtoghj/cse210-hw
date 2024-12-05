using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
       Video video1 = new Video { Title = "Resilence in Depression", Author = "DestinyNiesi", Length = 300 };
       Video video2 = new Video { Title = "Learn C#", Author = "Khan Academy", Length = 450 };

       Video video3 = new Video {Title = "Try not to laugh", Author = "JustGeeking", Length = 400 };

       video1.AddComment(new Comment {Name = "Elon", Text = "Nice video. Learned alot"});
       video1.AddComment(new Comment {Name = "Musk", Text = "Very helpful, thanks"});
       video1.AddComment(new Comment {Name = "Trump", Text = "I love this video!"});

       video2.AddComment(new Comment {Name = "Donald", Text = "This was amazing"});
       video2.AddComment(new Comment {Name = "Kim", Text = "Clear and concise explaination"});
       video2.AddComment(new Comment {Name = "Sunny", Text = "Terrific!"});

       video3.AddComment(new Comment {Name = "Haaland", Text = "Very funny"});
       video3.AddComment(new Comment {Name = "Logan", Text = "Can't stop laughing"});
       video3.AddComment(new Comment {Name = "Ronaldo", Text = "SUIII!"});

       List<Video> videos = new List<Video> { video1, video2, video3 };

       foreach (var video in videos)
       {
        Console.WriteLine($"Title: {video.Title}");
        Console.WriteLine($"Author: {video.Author}");
        Console.WriteLine($"Length: {video.Length} seconds");
        Console.WriteLine($"Number of Comments: {video.CountComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in video.GetComments())
        {
            Console.WriteLine($" - {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
       }
    }
}
