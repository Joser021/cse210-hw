using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Rua dos Padres, 123", "São Luís", "MA", "Brazil");
        Address address2 = new Address("123 Main St", "Springfield", "IL", "USA");

        Customer customer1 = new Customer("Pedro Lucas", address1);
        Customer customer2 = new Customer("Fletcher Green", address2);

        Product product1 = new Product("Red Shirt", "A001", 20.0, 2);
        Product product2 = new Product("Shoes", "A002", 35.0, 1);

        Product product3 = new Product("Headset Gamer", "B100", 50.0, 1);
        Product product4 = new Product("Mouse Gamer", "B101", 30.0, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // displaying on the terminal
        Console.WriteLine("Order 01");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total: ${order1.GetTotalCost()}");
        Console.WriteLine("------------------------------------");

        Console.WriteLine("Order 02");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total: {order2.GetTotalCost()}");
        Console.WriteLine();
    }
}