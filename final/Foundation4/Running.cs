using System;

public class Running: Activity{
    private double _distance;

    public Running(string date, double minutes, string name, double distance) :base(date, minutes, name){
        _distance = distance;
    }
   
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance/Minutes)*60;
    }

    public override double GetPace()
    {
        return(Minutes/ _distance);
    }

    public override string GetSummary()
    {
        return $"{Date} {Name} ({Minutes} min)- Distance {string.Format("{0:#.0}",GetDistance())} miles, Speed {string.Format("{0:#.0}",GetSpeed())} mph, Pace: {string.Format("{0:#.0}",GetPace())} min per mile ";
    }
}