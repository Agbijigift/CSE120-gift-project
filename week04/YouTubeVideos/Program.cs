using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Video video1 = new Video("C# Tutorial-Full Course for beginners", "freeCodeCamp", 600);
        Video video2 = new Video("The best Tech Jobs in 2025", "Programming with mosh", 1200);
        Video video3 = new Video("Machine Learning with C#", "AI Insights", 1800);

        
        video1.AddComment(new Comment("Parker", "This is kinda cool"));
        video1.AddComment(new Comment("John", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Beauty", "Could you cover more examples?"));

        
        video2.AddComment(new Comment("Ruth", "This was very informative!"));
        video2.AddComment(new Comment("Gift", "Can you do a follow-up on interfaces?"));
        video2.AddComment(new Comment("James", "Good pacing, easy to follow."));

        
        video3.AddComment(new Comment("Smith", "Wow, never knew C# could do this!"));
        video3.AddComment(new Comment("Blessing", "I love AI topics, thanks!"));
        video3.AddComment(new Comment("Peter", "Exciting, will try this out."));

    
        List<Video> videos = new List<Video> { video1, video2, video3 };

    
        foreach (var video in videos)
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment._commenter}: {comment._text}");
            }
        }
    }
}
