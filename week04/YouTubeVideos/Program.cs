using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Learn C# in 20 Minutes",
            "Code Academy",
            1200);

        video1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Bob", "I learned a lot."));
        video1.AddComment(new Comment("Charlie", "Please make more videos."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Top 10 Travel Destinations",
            "Travel World",
            900);

        video2.AddComment(new Comment("David", "Amazing places!"));
        video2.AddComment(new Comment("Emma", "Adding these to my bucket list."));
        video2.AddComment(new Comment("Frank", "Great video quality."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "Easy Chocolate Cake Recipe",
            "Cooking With Sarah",
            600);

        video3.AddComment(new Comment("Grace", "Looks delicious!"));
        video3.AddComment(new Comment("Henry", "I tried it and loved it."));
        video3.AddComment(new Comment("Ivy", "Thanks for sharing."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video(
            "Morning Workout Routine",
            "Fitness Hub",
            750);

        video4.AddComment(new Comment("Jack", "Perfect workout."));
        video4.AddComment(new Comment("Kelly", "Very motivating."));
        video4.AddComment(new Comment("Leo", "I feel energized already."));
        videos.Add(video4);

        // Display videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}