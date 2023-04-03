using System;

public class Address{
    private string _street {get; set;}
    private string _city {get; set;}
    private string _state {get; set;}
    private int _zip {get; set;}
    private string _country {get; set;}

    public Address(string street, string city, string state, int zip, string country){
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }

    public string FullAddress(){
        string address = $"{_street} \n {_city}, {_state} {_zip} {_country}";
        return address;
    }

    
}