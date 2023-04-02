using System;
using System.Collections;

class Event
{
    protected string _title;
    protected string _description;
    public string _type; 
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventSummary;
    public Event()
    {

    }
    public virtual string getEvent(string title, string desc, string type, string date, string time, string address)
    {
        _title = title;
        _description = desc;
        _type = type;
        _date = date;
        _time = time;
        _address = address;
        _eventSummary = $"{_title}, {_description} ({_type})\n{_date}, at {_time} {_address}";
        return _eventSummary;

    }

    public virtual string getStandard()
    {
        return "";
    }
    public virtual string getDetails()
    {
        return "";
    }

    public virtual string getShort()
    {
        return "";
    }
}