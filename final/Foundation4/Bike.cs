using System;

public class Bike: Activity{
    private double _speed;

    public Bike(string date, double minutes, string name, double speed): base(date, minutes, name){
        _speed = speed;
    }
   
    public override double GetDistance()
    {
        return (_speed* Minutes)/60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return Minutes /GetDistance();
    }

       public override string GetSummary()
    {
        return $"{Date} {Name} ({Minutes} min)- Distance {string.Format("{0:#.0}",GetDistance())} miles, Speed {string.Format("{0:#.0}",GetSpeed())} mph , Pace: {string.Format("{0:#.0}",GetPace())} min per mile ";
    }
}