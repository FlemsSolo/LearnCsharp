using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

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
            new Product("åLaptop", "Electronics", 1200.99m),
            new Product("øPhone", "Electronics", 799.49m),
            new Product("Tablet", "Electronics", 499.99m),
            new Product("Desk", "Furniture", 150.00m),
            new Product("Chair", "Furniture", 85.50m),
            new Product("Monitor", "Electronics", 299.99m)
        };

        // Step 3: Display all products
        Console.WriteLine("All Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name} - {product.Category} - ${product.Price}");
        }

        
        // Step 4: Use .Where to filter products in the Electronics category and priced above $500
        var filteredProducts = products
            .Where(p => p.Category == "Electronics" && p.Price > 500)
            .OrderByDescending(p => p.Price)
            .ToList();

        // Step 5: Display the filtered and sorted list
        Console.WriteLine("\nFiltered and Sorted Products (Electronics, Price > $500):");
        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"{product.Name} - {product.Category} - ${product.Price}");
        }
    }
}