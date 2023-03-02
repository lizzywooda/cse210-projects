
public class Scripture
{
    private List<int> _wordsHidden = new List<int>();

    public (List<Word>, Reference) SplitWords(List<string> scripture)
    {
        List<Word> instanceList = new List<Word>();
        string content = scripture[1];
        string refer = scripture[0];
        Reference reference = new Reference(refer);

        string[] words = content.Split(" ");
        foreach (string i in words)
        {
            Word word = new Word(i);
            instanceList.Add(word);
        }
        return (instanceList, reference);
    }


    public void DisplayScripture(List<Word> instanceList, Reference reference)
    {
        Console.Clear();
        Console.WriteLine(reference.GetReference());
        foreach (Word word in instanceList)
        {
            word.DisplayWord();
        }
    }

    public bool CheckHiddenWords(List<Word> instanceList)
    {
        int count = 0;
        foreach (Word word in instanceList)
        {
            if (word.GetIsHidden())
            {
                count++;
            }
        }

        if (count != instanceList.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public List<Word> HideWords(List<Word> instanceList, int numOfWords)
    {
        for (int j = 0; j < numOfWords; j++)
        {
            Random random = new Random();
            int index = random.Next(0, instanceList.Count);
            bool work = CheckHiddenWords(instanceList);

            if (work)
            {
                if (instanceList[index].GetIsHidden() == false)
                {
                    Word underscore = instanceList[index].HideWord();
                    instanceList[index] = underscore;
                }
                else
                {
                    j--;
                }
            }

        }
        return instanceList;
    }

}
