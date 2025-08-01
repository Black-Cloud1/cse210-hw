using System;

class Program
{
    static void Main(string[] args)

    {
        Address address1 = new Address("420 south 19st", "Richmond", "CA", "USA");
        Customer customer1 = new Customer("Heriberto Villa", address1);

        Product product1 = new Product("Computer", "ROG2", 1200, 1);
        Product product2 = new Product("Laptop Stand", "B2002", 29, 1);
        List<Product> products = new List<Product> { product1, product2 };

        Order order1 = new Order(products, customer1);

        Console.WriteLine("PACKING LABEL:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
    }
}