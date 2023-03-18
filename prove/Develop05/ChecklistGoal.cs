public class ChecklistGoal:Goal
{
    int _duration = 0;
    int _bonusPoints = 0;
    int _completedTimes = 0;
    public int CompletedTimes {
        set{_completedTimes = value;}
    }
    public ChecklistGoal(string goalName,string goalDescription,int points, int duration, int bonusPoints):base(goalName,goalDescription,points)
    {
        _duration = duration;
        _bonusPoints = bonusPoints;
    }
    public override void DisplayGoal(string number)
    {
        string x = _completedTimes >= _duration ? "x" : " ";
       Console.WriteLine(number + $". [{x}] {GoalName} ({GoalDescription}) -- Currently completed: {_completedTimes}/{_duration}");
    }
    public override void CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
        IsComplete = true;
        _completedTimes++;
        if(_completedTimes == _duration){
            Console.WriteLine();
            Console.WriteLine($"Congratulations! You earned {_bonusPoints} bonus points.");
        }
    }
    public override int GetCompletedPoints()
    {
        int completedPoints = base.GetCompletedPoints();
        // how to add bonus points
        if (_completedTimes>1 & _completedTimes<_duration){
            completedPoints = Points + base.GetCompletedPoints();
        }
        if(_completedTimes == _duration){
            completedPoints = completedPoints + _bonusPoints;
        }
        return completedPoints;
    }
    public override string GetSaveText() {
        return $"3#{GoalName}#{GoalDescription}#{Points}#{IsComplete}#{IsDeleted}#{_duration}#{_bonusPoints}#{_completedTimes}";
    }
}