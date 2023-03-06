public class Listing : Activity
{
    private int _listCount = 0;
    private string _answer = "";
    List<string> _listPrompts = new List<string>();
    List<string> _answers = new List<string>();
    public Listing():base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){
        _listPrompts.Add("Who are people that you appreciate?");
        _listPrompts.Add("What are personal strengths of yours?");
        _listPrompts.Add("Who are people that you have helped this week?");
        _listPrompts.Add("When have you felt the Holy Ghost this month?");
        _listPrompts.Add("Who are some of your personal heroes?");
    }
    public override void DisplayActivity()
    {
        base.DisplayActivity();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetPrompt(_listPrompts)} ---");
        Console.Write("You may begin in: ");
        Timer(5);
        Console.WriteLine();

        DateTime currentTime = DateTime.Now;
        DateTime durationTime = currentTime.AddSeconds(Duration);

        while (currentTime < durationTime)
        {
            Console.Write("> ");
            _answer = Console.ReadLine();
            _answers.Add(_answer);
            currentTime = DateTime.Now;
        }

        _listCount = _answers.Count();
        Console.WriteLine();
        Console.WriteLine($"You listed {_listCount} items");

        DisplayTheEnd();
    }
}