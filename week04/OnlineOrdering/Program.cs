using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the OnlineOrdering Project.");

        Product product1 = new Product("Nails", "nail-123456", 1.25, 50);
        Product product2 = new Product("Hammer", "hammer-123456", 5.00, 1);
        Product product3 = new Product("Screwdriver", "screwdriver-123456", 7.50, 2);
        Product product4 = new Product("Wood Screws", "screw-123456", 0.15, 100);
        Product product5 = new Product("Tape Measure", "tape-123456", 9.99, 1);
        Product product6 = new Product("Wood Glue", "glue-123456", 4.25, 3);
        Product product7 = new Product("Sandpaper", "sandpaper-123456", 0.75, 10);

        Customer customer1 = new Customer("Homer Simpson", new Address("742 Evergreen Terrace", "Springfield", "Alabama", "USA"));
        Customer customer2 = new Customer("Freddy Mercury", new Address("22 Gladstone Avenue", "Feltham", "London", "England"));

        Order order1 = new Order(customer1);
        order1.AddProductToOrder(product1);
        order1.AddProductToOrder(product2);
        order1.AddProductToOrder(product3);
        order1.AddProductToOrder(product4);

        Order order2 = new Order(customer2);
        order2.AddProductToOrder(product5);
        order2.AddProductToOrder(product6);
        order2.AddProductToOrder(product7);
        order2.AddProductToOrder(product3);

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Order 1");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Price:{order1.GetTotalCost()}");

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("\nOrder 2");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Price:{order2.GetTotalCost()}");
    }
}