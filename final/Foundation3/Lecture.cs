using System;

public class Lecture: Event{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string eventType, string speaker, int capacity): base(title, description, date, time, address, eventType){
        _speaker = speaker;
        _capacity = capacity;

    }

     public string LectureFullDetails(){
        
        return $" \n Speaker: {_speaker} \n Availability: {_capacity} people";
    }
}