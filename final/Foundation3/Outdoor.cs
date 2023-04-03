using System;

public class Outdoor: Event{
    private string _weather {get; set;}

    public Outdoor(string title, string description, string date, string time, Address address, string eventType, string weather): base(title, description, date, time, address, eventType){
       _weather = weather;

    }

     public string OutdoorFullDetails(){
        return $" \n Weather Forecast: {_weather}";
    }
}