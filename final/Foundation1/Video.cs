public class Video
{
    public List<Comment> _comments = new List<Comment>();
    private string _author;
    public string _title;
    public int _lenghtInSec;
    public Video(string author, string title, int lenghtInSec)
    {
        _author = author;
        _title = title;
        _lenghtInSec = lenghtInSec;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void Display()
    {
        Console.WriteLine(_author);
        Console.Write(_title);
        Console.Write(" - ");
        Console.WriteLine(_lenghtInSec);
        Console.WriteLine();
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

}