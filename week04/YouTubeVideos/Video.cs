using System.Diagnostics.Contracts;

public class Video
{
    private String _title;
    private String _author;
    private int _lenInSeconds;
    private List<Comment> _comments;

    public Video(String title, String author, int lenInSeconds)
    {
        _title = title;
        _author = author;
        _lenInSeconds = lenInSeconds;
        _comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title:{_title} Author:{_author} Length:{_lenInSeconds} seconds");
        Console.WriteLine($"\tThere are {GetNumberOfComments()} Comments :");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"\t{comment.GetDisplayText()}");
        }
        Console.WriteLine(" ");
    }

    public String GetDisplayText()
    {
        return $"Title:{_title} Author:{_author} Length:{_lenInSeconds} seconds";
    }

    public void SetComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }

}