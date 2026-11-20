using System.Runtime.CompilerServices;

public class Comment
{
    private String _name;
    private String _comment;

    public Comment(String name, String comment)
    {
        _name = name;
        _comment = comment;
    }

    public String getComment()
    {
        return _comment;
    }

    public String getName()
    {
        return _name;
    }
    public String GetDisplayText()
    {
        return $"Name:{_name} Comment:{_comment}";
    }

}