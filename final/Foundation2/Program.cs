using System;

class Program
{
    static void Main(string[] args)
    {
        // Create sample data
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("6 Dream St", "Belfrod", "NJ", "USA");
        Address address4 = new Address("261 Pedro St", "São Paulo", "ON", "Brazil");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Mary Green", address3);
        Customer customer4 = new Customer("Paul Dan", address4);

        Product product1 = new Product("Phone", "P1", 499.99, 2);
        Product product2 = new Product("Headphones", "P2", 99.99, 1);
        Product product3 = new Product("Keyboard", "P3", 69.99, 3);
        Product product4 = new Product("PS5", "P4", 300.00, 1);
        Product product5 = new Product("Smart Tv", "P5", 49.99, 1);
        Product product6 = new Product("Mac Book", "P6", 269.99, 3);

        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product2, product3 });
        Order order3 = new Order(customer3, new List<Product> { product4, product6 });
        Order order4 = new Order(customer4, new List<Product> { product4, product5 });

        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine(" ");
        Console.WriteLine("Order 2:");
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine(" ");
        Console.WriteLine("Order 3:");
        Console.WriteLine("Total Cost: $" + order3.CalculateTotalCost());
        Console.WriteLine("Packing Label:\n" + order3.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order3.GetShippingLabel());
        Console.WriteLine(" ");
        Console.WriteLine("Order 4:");
        Console.WriteLine("Total Cost: $" + order4.CalculateTotalCost());
        Console.WriteLine("Packing Label:\n" + order4.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order4.GetShippingLabel());
    }
}