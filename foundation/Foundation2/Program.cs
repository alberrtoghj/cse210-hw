using System;
using System.Runtime.CompilerServices;

class Programs
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Lagos", "LAG", "Nigeria");
        Address address2 = new Address("911 Maple Ave", "MinJae", "MJ", "North Korea");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", "L123", 999.99m, 1);
        Product product2 = new Product("Mouse", "M456", 19.99m, 2);
        Product product3 = new Product("Keyboard", "K789", 49.99M, 1);

        Product product4 = new Product("Tablet", "T234", 299.99m, 1);
        Product product5 = new Product("Phone Case", "P567", 15.99m, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
    }
}