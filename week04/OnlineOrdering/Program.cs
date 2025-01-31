using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Product product1 = new Product("Laptop", "P001", 1200.00, 1);
        Product product2 = new Product("Wireless Mouse", "P002", 25.99, 2);
        Product product3 = new Product("Keyboard", "P003", 45.50, 1);

        Product product4 = new Product("Smartphone", "P004", 999.99, 1);
        Product product5 = new Product("Earbuds", "P005", 79.99, 2);

        
        Customer customer1 = new Customer("Alice Johnson", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Bob Smith", new Address("456 Queen St", "Toronto", "ON", "Canada"));

        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        
        DisplayOrderDetails(order1);
        Console.WriteLine("\n-----------------------------------\n");
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:\n" + order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + order.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order.GetTotalCost());
    }
}