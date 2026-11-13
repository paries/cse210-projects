public class Word
{
    private String _text;
    private bool _isHidden;

    public Word(String text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public String GetDisplayText()
    {
        if ( !_isHidden)
        {
            return _text;
        }
        else
        {
            String blank = "";
            foreach (char c in _text)
            {
                blank += "_";
            }
            return blank;
        }
    }
}