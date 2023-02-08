using System;

class Entry
{
    Random random = new Random();
    public DateTime _date = DateTime.Now;
    public string _prompt;
    public string _userInput;
    List<string> _prompts = new List<string>
    {
        "How was your day?",
        "What was the best part of your day?",
        "What was the worst part of your day?",
        "What could have made your day better?"
    };
    
    
    
    public void  Display() 
    {
        Console.WriteLine($"{_date} - {_prompt} - {_userInput}\n");
    }

    public void Fill()
    {
        int _randomNumber = random.Next(4);
       _prompt = _prompts[_randomNumber];
       Console.WriteLine($"{_prompt}");
       _userInput = Console.ReadLine();
    }

}