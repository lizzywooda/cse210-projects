
public class Word
{
    private string _word;
    private bool _wordHidden;

    public Word(string word)
    {
        _word = word;
        _wordHidden = false;
    }

    public Word(string word, bool hidden)
    {
        _word = word;
        _wordHidden = true;
    }


    public void DisplayWord()
    {
        Console.Write(_word);
        Console.Write(" ");
    }
    public Word HideWord()
    {
        List<string> underscoreList = new List<string>();
        int length = _word.Length;
        foreach (char letter in _word)
        {
            if (char.IsLetter(letter))
            {
                underscoreList.Add("_");
            }
            else
            {
                underscoreList.Add($"{letter}");
            }
        }
        string underscore = string.Join("", underscoreList);
        Word newWord = new Word(underscore, true);
        return newWord;
    }

    public string GetSingleWord()
    {
        return _word;
    }

    public bool GetIsHidden()
    {
        return _wordHidden;
    }

}
