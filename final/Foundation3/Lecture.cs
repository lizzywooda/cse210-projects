using System;
using System.Collections;

class Lecture : Event
{
    protected string _speaker;
    
    public string _eventType = "Lecture";
    protected int _capacity;
    protected string _lectureSummary;

    public Lecture()
    {

    }
    public Lecture(string speaker, int seats)
    {
        string type = _type;
        string date = _date;
        string time = _time;
        string addy = _address;
        _speaker = speaker;
        string desc = _description;
        _capacity = seats;
        _lectureSummary = $"{_speaker}, {desc}, {date} {time}, at {addy}. {_capacity} Seats are available.";
        
    }
    public override string getStandard()
    {
        
        return $"-------------------- {_title} Featuring guest speaker {_speaker} {_date}, {_time} {_address} -------------------- ";
    }
    public override string getShort()
    {
        return $"---------- {_type} by {_speaker} {_title} {_date} ---------- ";
    }
    public override string getDetails()
    {
        return $"     *****     --- {_title} ---\nA special Lecture by {_speaker} When: {_date}, at {_time} Where: {_address} >>> Seating is limited to {_capacity}, so reserve your seat soon <<<     *****     ";
    }
}