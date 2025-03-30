using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("John Doe", new Address("USA", "New York", "NY", "123 Main St"));
        Customer customer2 = new Customer("Jane Smith", new Address("Canada", "Toronto", "ON", "456 Maple Ave"));
        
        // List<Product> products1 = new List<Product>
        // {
        //     new Product("Laptop", 999.99, 1, 101),
        //     new Product("Mouse", 25.50, 2, 102),
        //     new Product("Keyboard", 49.99, 1, 103)
        // };
        // List<Product> products2 = new List<Product>
        // {
        //     new Product("Smartphone", 699.99, 1, 201),
        //     new Product("Charger", 19.99, 3, 202),
        //     new Product("Headphones", 89.99, 1, 203)
        // };

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(new Product("Laptop", 999.99, 1, 101));
        order1.AddProduct(new Product("Mouse", 25.50, 2, 102));
        order1.AddProduct(new Product("Keyboard", 49.99, 1, 103));
        
        order2.AddProduct(new Product("Smartphone", 699.99, 1, 201));
        order2.AddProduct(new Product("Charger", 19.99, 3, 202));
        order2.AddProduct(new Product("Headphones", 89.99, 1, 203));
        // Display order details

        Console.Clear();
        Console.WriteLine("Order 1 Details:");
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine($"Total Price: {order1.GetTotalPrice()}");
        Console.WriteLine("----------------------");
        Console.WriteLine("Order 2 Details:");
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine($"Total Price: {order2.GetTotalPrice()}");
        Console.WriteLine("----------------------");
    }
}