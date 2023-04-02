using System;
using System.Collections;

class Outdoor : Event
{
    protected string _weather;

    public string _eventType = "Outdoor Event";

    public Outdoor()
    {

    }
    public Outdoor(string forecast)
    {
        _weather = forecast;
    }

    public override string getStandard()
    {
        return $"   ---   ---   ---     {_title} {_description} {_date}, {_time} Location: {_address}    ---   ---   ---   ";
    }

    public override string getDetails()
    {
        return $" ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  {_title} {_description}  When: {_date}, at {_time} Location: {_address}  This is An outdoor event! Please come dressed and prepared for {_weather}  ~ ~ ~ ~ ~ ~ ~ ~ ~ ~  ";
    }

    public override string getShort()
    {
        return $"---------- {_title} An {_type} event {_date} ---------- ";
    }
}