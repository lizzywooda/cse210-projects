using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Jhon Doe");
        Customer customer2 = new Customer("Jane Doe");
        Customer customer3 = new Customer("Liz Canepari");

        Address address1 = new Address();
        address1.SetAddress("123 Nothing St");
        address1.SetCity("Nowhere");
        address1.SetCountry("USA");
        address1.SetState("ID");
        Address address2 = new Address();
        address2.SetAddress("456 Fake Ave");
        address2.SetCity("Fakevil");
        address2.SetCountry("USA");
        address2.SetState("ID");
        Address address3 = new Address();
        address3.SetAddress("789 Where Dr");
        address3.SetCity("Somewhere");
        address3.SetCountry("CAN");
        address3.SetState("Ontario");

        customer1.SetAddress(address1);
        customer2.SetAddress(address2);
        customer3.SetAddress(address3);

        Product product1 = new Product("Coffee Table", 123456, 44.99);
        Product product2 = new Product("Couch", 789123, 199.99);
        Product product3 = new Product("Love Seat", 345678, 120.00, 2);
        Product product4 = new Product("Book Shelf", 910112, 49.99, 3);
        Product product5 = new Product("TV Stand", 121314, 399.99);
        Product product6 = new Product("Electric Fireplace", 151617, 60.25, 2);
        Product product7 = new Product("Twin Bed Frame", 181920, 43.78, 2);
        Product product8 = new Product("Queen Bed Frame", 212223, 73.45,1);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order2.AddProduct(product6);
        order2.AddProduct(product5);
        order2.AddProduct(product4);

        order3.AddProduct(product5);
        order3.AddProduct(product8);
        order3.AddProduct(product7);

        Console.Clear();
        order1.PrintPackingLabel();
        Console.WriteLine();
        order1.PrintShippingLabel();
        Console.WriteLine("------------------------");
        order2.PrintPackingLabel();
        Console.WriteLine();
        order2.PrintShippingLabel();
        Console.WriteLine("------------------------");
        order3.PrintPackingLabel();
        Console.WriteLine();
        order3.PrintShippingLabel();
        Console.WriteLine("------------------------");
    }
}