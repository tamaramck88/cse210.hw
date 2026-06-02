using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order (USA)

        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Laptop", "P100", 800, 1);
        Product product2 = new Product("Mouse", "P101", 25, 2);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Second Order (Outside USA)

        Address address2 = new Address(
            "45 Mandela Road",
            "Johannesburg",
            "Gauteng",
            "South Africa"
        );

        Customer customer2 = new Customer("Sarah Johnson", address2);

        Product product3 = new Product("Keyboard", "P200", 50, 1);
        Product product4 = new Product("Monitor", "P201", 200, 2);
        Product product5 = new Product("Headset", "P202", 75, 1);

        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Order 1

        Console.WriteLine("ORDER 1");
        Console.WriteLine("--------------------");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        // Display Order 2

        Console.WriteLine("ORDER 2");
        Console.WriteLine("--------------------");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}