using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<YouTubeVideo> videos = new List<YouTubeVideo>();

        // First Video
        YouTubeVideo video1 = new YouTubeVideo("Learn C# in 10 minutes", "ResilienceLab.Africa", 600);
        video1.AddComment(new Comment("Alice", "Excellent tutorial!"));
        video1.AddComment(new Comment("Alex", "This is so helpful, thanks for sharing."));
        video1.AddComment(new Comment("Stacy", "Great content, quick suggestion for more advanced topics like polymorphism."));
        videos.Add(video1);

        // Second Video
        YouTubeVideo video2 = new YouTubeVideo("Introduction to Machine Learning", "TechDev", 1200);
        video2.AddComment(new Comment("Charles", "I love machine learning!"));
        video2.AddComment(new Comment("Diana", "Please make a follow-up video on neural networks"));
        video2.AddComment(new Comment("LukeSkywalker", "Can you please explain more on supervised vs unsupervised learning?"));
        videos.Add(video2);

        YouTubeVideo video3 = new YouTubeVideo("The top 10 programming languages in 2025", "CodeUniverse", 900);
        video3.AddComment(new Comment("Mandla", "Very informative!"));
        video3.AddComment(new Comment("Nalo", "I was surprised to see Rust on the list."));
        video3.AddComment(new Comment("Sizwe", "Can you provide more details on why Python is still so popular?"));
        videos.Add(video3);

        // To display all videos and their comments
        foreach (YouTubeVideo video in videos)
        {
            video.Display();
        }
        
    }

}    

