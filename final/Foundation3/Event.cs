using System;

public class Event{
    private string _title {get; set;}
    private string _description {get; set;}
    private string _date {get; set;}
    private string _time {get; set;}
    private Address _address {get;}
    private string _eventType {get; set;}

    

    public Event(string title, string description, string date, string time, Address address, string eventType){
        _title = title;
        _description = description;
        _time = time;
        _address = address;
        _date = date;
        _eventType = eventType;
    }
   

    public string StandardDetails(){
        Address address = _address;
        string stand = $"{_title}\n {_description}\n When:{_date} \n Time:{_time} \n Where: {address.FullAddress()}";
        return stand; 
    }
   
    public string FullDetails(){
        Address address = _address;
        string stand2 = $"{_title} \n {_description} \n When:{_date} \n Time:{_time} \n Where: {address.FullAddress()} \n Event Type: {_eventType}";
        return stand2; 
    }
    public string ShortDetails(){
        return $"Event Type:{_eventType} \n Name of Event:{_title} \n When:{_date}";
    }
    }