using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        string input;
        while ((input = Console.ReadLine()) != "buy")
        {
            string[] data = input.Split();
            string name = data[0];
            double price = double.Parse(data[1]);
            int quantity = int.Parse(data[2]);

            if (products.ContainsKey(name))
            {
                Product existingProduct = products[name];
                existingProduct.Quantity += quantity;
                if (existingProduct.Price != price)
                {
                    existingProduct.Price = price;
                }
            }
            else
            {
                Product newProduct = new Product(name, price, quantity);
                products[name] = newProduct;
            }
        }

        foreach (var product in products)
        {
            string productName = product.Key;
            Product productData = product.Value;
            double totalPrice = productData.Price * productData.Quantity;
            Console.WriteLine($"{productName} -> {totalPrice:f2}");
        }
    }
}

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}
