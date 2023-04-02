public class Customer
{
    private string _name;
    private Address _address = new Address();

    public Customer(string name)
    {
        _name = name;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public bool LivesInUSA()
    {
        if (_address.IsInUsa())
            return true;
        else
            return false;
    }
    public void Display()
    {
        Console.WriteLine(_name);
        _address.Display();
    }
}