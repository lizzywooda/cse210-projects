public class Activity
{
    private string _startMessage = "Welcome to the ";
    private string _endMessage = "Well Done!!";
    private int _duration = 0;
    private string _activityName = "";
    private string _activityDescription = "";
    protected int Duration { get { return _duration; } }
    protected string ActivityName { get { return _activityName; } }
    protected string ActivityDescription { get { return _activityDescription; } }
    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }
    public void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine($"{_startMessage}{_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready... ");
        Spinner(3);
        Console.WriteLine();
    }

    public void DisplayEnd()
    {
        Console.WriteLine();
        Console.WriteLine(_endMessage);
        Spinner(3);
        Console.WriteLine($"You completed {Duration} seconds of the {ActivityName}");
        Spinner(3);
        Thread.Sleep(3000);
        Console.Clear();
    }

    public virtual void DisplayActivity()
    {
        DisplayWelcome();
    }
    public virtual void DisplayTheEnd()
    {
        DisplayEnd();
    }
    public string GetPrompt(List<string> prompts)
    {
        Random r = new Random();
        int index = r.Next(0, prompts.Count);
        return prompts[index];
    }

    public void Timer(int i)
    {
        while (i >= 0)
        {
            Console.Write("\b \b");
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            i--;
        }
    }
    public void Spinner(int i)
    {
        int count = 0;
        do
        {
            Console.Write('|');
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write('/');
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write('-');
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            count += 1;
        } while (count != i);
    }
}