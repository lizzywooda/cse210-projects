public class EternalGoal:Goal
{
    int clCompleted = 0;
    public int CompletedTally {
        set {clCompleted = value; }
    }
    public EternalGoal(string goalName,string goalDescription,int points):base(goalName,goalDescription,points)
    {}
    public override void DisplayGoal(string number)
    {
       Console.WriteLine(number + $". [ ] {GoalName} ({GoalDescription}) ");
    }
    public override void CompleteGoal()
    {
        IsComplete = true;
        Console.WriteLine($"Congratulations! You have earned {Points} points!");   
        clCompleted++;
    }
    public override int GetCompletedPoints()
    {
        int clTotalPoints = clCompleted*Points;
        return clTotalPoints;
    }
    public override string GetSaveText() {
        return $"2#{GoalName}#{GoalDescription}#{Points}#{IsComplete}#{IsDeleted}#{clCompleted}";
    }
}