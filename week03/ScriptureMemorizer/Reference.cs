using System.Collections.Concurrent;

public class Reference
{
    private String _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(String book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(String book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public String GetDisplayText()
    {
        String verseString = $"{ _verse}";
        if ( _endVerse > 0)
        {
            verseString += $"-{_endVerse}";
        }

        return $"{_book} {_chapter}:{verseString}";
    }
}