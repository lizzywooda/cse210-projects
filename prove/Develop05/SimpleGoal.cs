public class SimpleGoal:Goal
{
    public SimpleGoal(string goalName,string goalDescription,int points):base(goalName,goalDescription,points)
    { }
    public override void DisplayGoal(string number)
    {
        string x = IsComplete ? "x" : " ";
       Console.WriteLine(number + $". [{x}] {GoalName} ({GoalDescription}) ");
    }
    public override void CompleteGoal()
    {
        IsComplete = true;
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
    }
    public override int GetCompletedPoints()
    {
        return base.GetCompletedPoints();
    }
    public override string GetSaveText() {
        return $"1#{GoalName}#{GoalDescription}#{Points}#{IsComplete}#{IsDeleted}";
    }
}  