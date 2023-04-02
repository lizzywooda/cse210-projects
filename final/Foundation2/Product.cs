public class Product{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name,  int id, double price, int quantity = 1)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    
    public double GetPrice()
    {
        return _price * _quantity;
    }
    public void Display()
    {
        Console.Write($"{_name}");
        Console.WriteLine($" #{_id}");
        Console.WriteLine($"${_price} x{_quantity}");
        Console.WriteLine($"\tPrice: {GetPrice()}");
        Console.WriteLine();
    }
}