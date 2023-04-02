public class Comment
{
    private string _userName;
    private string _text;

    public Comment(string userName, string text)
    {
        _text = text;
        _userName = userName;
    }
    public void Display()
    {
        Console.Write('\t');
        Console.WriteLine(_userName);
        Console.Write('\t');
        Console.WriteLine(_text);
        Console.WriteLine();
    }
}