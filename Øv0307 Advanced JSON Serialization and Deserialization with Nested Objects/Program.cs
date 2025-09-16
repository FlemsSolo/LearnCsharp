using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }

    public Product(string name, decimal price, bool isAvailable)
    {
        Name = name;
        Price = price;
        IsAvailable = isAvailable;
    }
}

class Category
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }

    public Category(string name, List<Product> products)
    {
        Name = name;
        Products = products;
    }
}

class Program
{
    static void Main()
    {
        // Step 2: Create a list of categories with nested products
        List<Category> categories = new List<Category>
        {
            new Category("Electronics", new List<Product>
            {
                new Product("Laptop", 1200.99m, true),
                new Product("Phone", 799.49m, false),
                new Product("Tablet", 499.99m, true)
            }),
            new Category("Furniture", new List<Product>
            {
                new Product("Desk", 150.00m, true),
                new Product("Chair", 85.50m, true),
                null
            })
        };

        // Step 3: Configure custom JSON serialization options
        var options = new JsonSerializerOptions
        {
            WriteIndented = true, // Format JSON with indentation
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull // Ignore null values
        };

        // Step 4: Serialize the list of categories to JSON
        string json = JsonSerializer.Serialize(categories, options);

        // Step 5: Display the formatted JSON string
        Console.WriteLine("Serialized JSON:\n" + json);

        // Step 6: Deserialize the JSON string back into a list of Category objects
        List<Category> deserializedCategories = JsonSerializer.Deserialize<List<Category>>(json, options);

        // Step 7: Display the deserialized categories and their products
        Console.WriteLine("\nDeserialized Categories and Products:");
        foreach (var category in deserializedCategories)
        {
            Console.WriteLine($"Category: {category.Name}");
            foreach (var product in category.Products)
            {
                if (product != null)
                  Console.WriteLine($"  - {product.Name} | Price: ${product.Price} | Available: {product.IsAvailable}");
            }
        }
    }
}