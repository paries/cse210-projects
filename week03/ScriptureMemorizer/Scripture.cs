using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<int> _hiddenIdxs = new List<int>();

    private bool _allHidden;
    public Scripture(Reference reference, String text)
    {
        foreach (String word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
        _reference = reference;
        _allHidden = false;
    }
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Boolean hidOne = false;
            int maxWords = _words.Count;
            int tryCnt = 0;
            do
            {
                int indexToHide = Random.Shared.Next(0, _words.Count);
                if (!_hiddenIdxs.Contains(indexToHide))
                {
                    _words[indexToHide].Hide();
                    _hiddenIdxs.Add(indexToHide);
                    hidOne = true;
                }
                tryCnt++;
            } while (!hidOne && tryCnt < (maxWords * 5));

            if (_words.Count == _hiddenIdxs.Count())
            {
                _allHidden = true;
                break;
            }

        }

    }

    public int GetWordCount()
    {
        return _words.Count;
    }

    public String GetDisplayText()
    {
        String text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {text}";
    }
    public bool IsCompletelyHidden()
    {
        return _allHidden;        
    }

}