public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    public GoalManager()
    { }
    public Goal AddGoal(string type, string goalName, string goalDescription, int points, int duration, int bonusPoints)
    {
        Goal g = null;
        if (type == "1")
        {
            g = new SimpleGoal(goalName,goalDescription,points);   
        }    
        else if (type == "2")
        {
            g = new EternalGoal(goalName,goalDescription,points); 
        }
        else if (type == "3")
        {
            g = new ChecklistGoal(goalName,goalDescription,points,duration, bonusPoints);
        }
        if(g != null) {
            goals.Add(g);
        }
        return g;
    }
    public void MarkComplete(int numberToComplete) //takes user input, subtracts 1 to get goal index
    {
        
        int lineNum = 1;
        Goal goalToComplete = null;
        foreach(Goal g in goals){
            if(!g.IsDeleted){
                if (lineNum == numberToComplete) {
                    goalToComplete = g;
                    break;
                }
                lineNum++;
            }
        }
        goalToComplete.CompleteGoal();
    }
    public void DisplayGoals() // Lists goals with numbers infront, and then calls individual goal DisplayGoal
    {
        int i = 1;  //numbered list of goals
        foreach(Goal g in goals){
            if(!g.IsDeleted){
                g.DisplayGoal(i.ToString());
                i++;
            }
        }
    }

    public void DeleteGoal(int numberToDelete){
        int lineNum = 1;
        Goal goalToDelete = null;
        foreach(Goal g in goals){
            if(!g.IsDeleted){
                if (lineNum == numberToDelete) {
                    goalToDelete = g;
                    break;
                }
                lineNum++;
            }
        }
        goalToDelete.IsDeleted = true;
    }

    public void DisplayGoalPointTotal()
    {
        int total = GetGoalPointTotal();
        Console.WriteLine($"You have {total} points");
    }

    private int GetGoalPointTotal() {
        int total = 0;
        foreach(Goal g in goals){
            total = total + g.GetCompletedPoints();
        }
        return total;
    }

    public void Load(string filename)
    {
        if (File.Exists(filename))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string totalLine = reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('#');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    string isComplete = parts[4];
                    string isDeleted = parts[5];
                    int duration = 0;
                    int bonusPoints = 0;
                    int completedTimes = 0;
                    if (type == "3")
                    {
                        duration = int.Parse(parts[6]);
                        bonusPoints = int.Parse(parts[7]);
                        completedTimes = int.Parse(parts[8]);
                    }
                    Goal g = AddGoal(type, name, description, points, duration, bonusPoints);
                    g.IsComplete = bool.Parse(isComplete);
                    g.IsDeleted = bool.Parse(isDeleted);
                    if(type == "2") {
                        int completedTally = int.Parse(parts[6]);
                        ((EternalGoal)g).CompletedTally = completedTally;
                    }
                    else if(type == "3"){
                        ((ChecklistGoal)g).CompletedTimes = completedTimes;
                    }
                }
            }
        }
    }
    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            int total = GetGoalPointTotal();
            writer.WriteLine(total);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetSaveText());
            }
        }
        goals.Clear();
    }
}