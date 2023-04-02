using System;

public class Activity{
    private string _date;
    private double _minutes;
    private string _name;
    
    public Activity(string date,  double minutes, string name){
        _date = date;
        _minutes = minutes;
        _name = name;

    }
    public string Date{
        get{
            return _date;
        }
        set{
            _date = value;
        }
    }
    public double Minutes{
        get{
            return _minutes;
        }
        set{
            _minutes = value;
        }
    }
    public string Name{
        get{
            return _name;
        }
        set{
            _name = value;
        }
    }
   
    public virtual  double GetDistance(){
       return 0;
    }

    public virtual double GetSpeed(){
       return 0;
    }

    public virtual double GetPace(){
        return 0;
  
    }
    
    public virtual string GetSummary(){
        return $"{_date} {_name} ({_minutes})- Distance {GetDistance}, Speed {GetSpeed}, Pace: {GetPace} ";
    }
  
  
}