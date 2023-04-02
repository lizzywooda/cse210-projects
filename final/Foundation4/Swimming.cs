using System;

public class Swimming: Activity{
    private double _laps {get; set;}

    public Swimming(string date, double minutes, string name, double laps): base(date, minutes, name){
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50 /1000)*.62;
    }

    public override double GetSpeed()
    {
        return (_laps /Minutes)*60;
    }

    public override double GetPace()
    {
        return Minutes/_laps;
    }

     public override string GetSummary()
    {
        return $"{Date} {Name} ({Minutes} min)- Distance {string.Format("{0:#.0}",GetDistance())} miles, Speed {string.Format("{0:#.0}",GetSpeed())} laps per hour, Pace: {string.Format("{0:#.0}",GetPace())} min per lap ";
    }
}