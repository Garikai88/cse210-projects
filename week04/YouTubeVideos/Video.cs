using System;
using System.Collections.Generic;

public class YouTubeVideo
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public YouTubeVideo(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_lengthInSeconds}");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
    

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
        }
    
        Console.WriteLine(); // This is a blank line between videos
    }   
}
