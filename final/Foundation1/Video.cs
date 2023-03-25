using System;

public class Video
{
    private string _title;
    private string _author;
    private int _durationSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _durationSeconds = seconds;
    }

    public void AddComment(string commentor, string text)
    {
        Comment comment = new Comment(commentor, text);
        _comments.Add(comment);

    }

    public int CommentCount()
    {
        return _comments.Count();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"TITLE: {_title}");
        Console.WriteLine($"AUTHOR: {_author}");
        Console.WriteLine($"DURATION (seconds): {_durationSeconds}");
    }
    public void DisplayAllComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetComment()}");
        }
    }
}
