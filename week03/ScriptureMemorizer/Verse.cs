public class Verse
{
    private String _book;
    private String _text;
    private int _chapter;
    private int _verse;

    public Verse(String book, String text, int chapter, int verse)
    {
        _book = book;
        _text = text;
        _chapter = chapter;
        _verse = verse;
    }

    public void SetBook(String book)
    {
        _book = book;
    }
    public String GetBook()
    {
        return _book;
    }

    public void SetText(String text)
    {
        _text = text;
    }
    public String GetText()
    {
        return _text;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public int GetChapter()
    {
        return _chapter;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public int GetVerse()
    {
        return _verse;
    }

}