public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
    }
    public void SetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }

    public bool IsInUsa()
    {
        if (_country == "USA")
            return true;
        else
            return false;
    }
    public void Display()
    {
        Console.WriteLine($"{_streetAddress}\n{_city}, {_state}, {_country}");
    }
}