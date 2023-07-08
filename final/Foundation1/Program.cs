using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("Commenter 1", "Great video!");
        video1.AddComment("Commenter 2", "I learned a lot.");

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("Commenter 3", "Nice explanation.");
        video2.AddComment("Commenter 4", "Could be more detailed.");

        Video video3 = new Video("Video 3", "Author 3", 240);
        video3.AddComment("Commenter 5", "This is amazing!");
        video3.AddComment("Commenter 6", "Keep up the good work.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("Commenter: " + comment.Commenter);
                Console.WriteLine("Comment: " + comment.Text);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}