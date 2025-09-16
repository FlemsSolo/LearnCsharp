using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }

    public Product(string name, string category, decimal price)
    {
        Name = name;
        Category = category;
        Price = price;
    }
}

class Program
{
    static void Main()
    {
        // Step 2: Create a List of products
        List<Product> products = new List<Product>
        {
            new Product("Laptop", "Electronics", 1200.99m),
            new Product("Phone", "Electronics", 799.49m),
            new Product("Tablet", "Electronics", 499.99m),
            new Product("Desk", "Furniture", 150.00m),
            new Product("Chair", "Furniture", 85.50m),
            new Product("Monitor", "Electronics", 299.99m),
            new Product("Ål", "Electronics", 999.99m)
        };

        // Step 3: Display all products
        Console.WriteLine("All Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name} - {product.Category} - ${product.Price}");
        }

        // Step 4: Ask the user to enter a product name
        Console.Write("\nEnter the name of the product to find: ");
        string searchName = Console.ReadLine();

        // Step 5: Use .SingleOrDefault to find the product
        var foundProduct = products.SingleOrDefault(p => p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

        // Step 6: Display the result or handle not found
        if (foundProduct != null)
        {
            Console.WriteLine($"Product found: {foundProduct.Name} - {foundProduct.Category} - ${foundProduct.Price}");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}