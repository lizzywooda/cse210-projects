public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public void CalculateCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice();
        }
        if (_customer.LivesInUSA()){
            total += 5;
            Console.Write($"\n\tShipping: $5.00\n");
        }
        else{
            total += 35;
            Console.Write($"\n\tShipping: $35.00\n");
        }
        Console.Write($"\n\tTotal: $");
        Console.WriteLine(total);
    }
    public void PrintShippingLabel()
    {
        _customer.Display();
        Console.WriteLine();        
    }
    public void PrintPackingLabel()
    {
        foreach (Product product in _products)
            product.Display();
        CalculateCost();
    }

}