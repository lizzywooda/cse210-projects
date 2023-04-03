using System;

public class Reception: Event{
    private string _email {get; set;}

    public Reception(string title, string description, string date, string time, Address address, string eventType, string email): base(title, description, date, time, address, eventType){
        _email = email;

    }
    public string ReceptionFullDetails(){
        return $" \n RSVP @: {_email}";
    }
}