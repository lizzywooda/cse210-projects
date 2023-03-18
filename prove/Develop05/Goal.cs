public abstract class Goal
{
    private string _goalName="";
    private string _goalDescription = "";
    private int _points=0;
    private bool _isComplete=false;

    private bool _isDeleted = false;

    protected string GoalName{
        get{
            return _goalName;
        }
    }
    protected string GoalDescription{
        get{
            return _goalDescription;
        }
    }
    protected int Points{
        get{
            return _points;
        }
    }
    public bool IsComplete{
        get{
            return _isComplete;
        }
        set{
            _isComplete = value;
        }
    }
    public bool IsDeleted{
        get{
            return _isDeleted;
        }
        set{
            _isDeleted = value;
        }
    }

    // constructor
    public Goal (string goalName, string goalDescription, int points)
    {
        _goalName=goalName;
        _goalDescription = goalDescription;
        _points = points;
    }
    public abstract void CompleteGoal();
    public abstract void DisplayGoal(string number);
    public abstract string GetSaveText();
    public virtual int GetCompletedPoints(){
        if(_isComplete){
            return _points;
        } else {
            return 0;
        }
    }
}