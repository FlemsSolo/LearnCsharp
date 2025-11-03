using System;
using System.Collections.Generic;
using System.Text.Json;

// Step 2: Prepare JSON data with different casing
string jsonData = @"
[
    { ""name"": ""Laptop"", ""PRICE"": 1200.99, ""isavailable"": true },
    { ""name"": ""Phone"", ""PRICE"": 799.49, ""isavailable"": false },
    { ""name"": ""Tablet"", ""PRICE"": 499.99, ""isavailable"": true }
]";

// Step 3: Attempt deserialization without case insensitivity
Console.WriteLine("Attempting deserialization without case insensitivity:");
try
{
    List<Product>? products = JsonSerializer.Deserialize<List<Product>>(jsonData);
    DisplayProducts(products ?? new List<Product>());
}
catch (Exception ex)
{
    Console.WriteLine($"Deserialization failed: {ex.Message}");
}

// Step 4: Deserialize using PropertyNameCaseInsensitive
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

Console.WriteLine("\nDeserialization with PropertyNameCaseInsensitive set to true:");
try
{
    List<Product>? productsInsensitive = JsonSerializer.Deserialize<List<Product>>(jsonData, options);
    DisplayProducts(productsInsensitive);
}
catch (Exception ex)
{
    Console.WriteLine($"Deserialization failed: {ex.Message}");
}

// ----------------------------------------------------------------------------------------------

// Method to display products
static void DisplayProducts(List<Product>? products)
{
    if (products == null)
    {
        Console.WriteLine("No products were deserialized.");
        return;
    }

    foreach (var product in products)
    {
        Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Available: {product.IsAvailable}");
    }
}

class Product
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
}
