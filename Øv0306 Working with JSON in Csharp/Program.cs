using System;
using System.Collections.Generic;
using System.Text.Json;

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
            new Product("Tablet", "Electronics", 499.99m)
        };

        // Step 3: Serialize the list of products to JSON
        string json = JsonSerializer.Serialize(products);
        
        // Step 4: Display the JSON string
        Console.WriteLine("Serialized JSON:\n" + json);

        // Step 5: Deserialize the JSON string back into a List of Product objects
        List<Product> deserializedProducts = JsonSerializer.Deserialize<List<Product>>(json);

        // Step 6: Display the deserialized products
        Console.WriteLine("\nDeserialized Products:");
        foreach (var product in deserializedProducts)
        {
            Console.WriteLine($"{product.Name} - {product.Category} - ${product.Price}");
        }
    }
}