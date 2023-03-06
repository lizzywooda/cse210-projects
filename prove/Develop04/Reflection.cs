public class Reflection : Activity
{
    private string _prompt;
    List<string> _firstPrompts = new List<string>();
    List<string> _secondPrompts = new List<string>();
    public Reflection() : base ("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _firstPrompts.Add("Think of a time when you stood up for someone else.");
        _firstPrompts.Add("Think of a time when you did something really difficult.");
        _firstPrompts.Add("Think of a time when you helped someone in need.");
        _firstPrompts.Add("Think of a time when you did something truly selfless.");

        _secondPrompts.Add("> Have you ever done anything like this before?");
        _secondPrompts.Add("> How did you get started?");
        _secondPrompts.Add("> Why was this experience meaningful to you?");
        _secondPrompts.Add("> How did you feel when it was complete?");
        _secondPrompts.Add("> What made this time different than other times when you were not as successful?");
        _secondPrompts.Add("> What is your favorite thing about this experience?");
        _secondPrompts.Add("> What could you learn from this experience that applies to other situations?");
        _secondPrompts.Add("> What did you learn about yourself through this experience?");
        _secondPrompts.Add("> How can you keep this experience in mind in the future?");
    }
    public override void DisplayActivity()
    {
        base.DisplayActivity();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {GetPrompt(_firstPrompts)} ---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:  ");
        Timer(3);
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        DateTime durrationTime = currentTime.AddSeconds(Duration);

        while (currentTime < durrationTime)
        {
            _prompt = GetPrompt(_secondPrompts);
            Console.WriteLine(_prompt);
            _firstPrompts.Remove(_prompt);
            Spinner(4);
            currentTime = DateTime.Now;
        }
        DisplayTheEnd();
    }

}