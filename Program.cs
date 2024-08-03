using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

class Program
{
    private static void Main(string[] args)
    {
        using var context = new DatabaseContext();

        fetchProducts(context);

        fetchCustomers(context);

        displayData(context);
    }

    private static void fetchProducts(DatabaseContext context)
    {
        using var httpClient = new HttpClient();
        
        var response = httpClient.GetStringAsync("https://eftechnical.azurewebsites.net/api/products").Result;

        var products = JsonSerializer.Deserialize<List<Product>>(response);

        if (products != null)
        {
            foreach (var product in products)
            {
                product.id = 0; 
            }
            context.Products.AddRange(products);
            context.SaveChanges();
            Console.WriteLine("The products data have been saved to the database.");
        }
    }

    private static void fetchCustomers(DatabaseContext context)
    {
        using var httpClient = new HttpClient();

        var response = httpClient.GetStringAsync("https://eftechnical.azurewebsites.net/api/customer").Result;

        var customers = JsonSerializer.Deserialize<List<Customer>>(response);

        if (customers != null)
        {
            foreach (var customer in customers)
            {
                customer.id = 0; 
            }
            context.Customers.AddRange(customers);
            context.SaveChanges();
            Console.WriteLine("The customers have been saved to the database.");
        }
    }

    private static void displayData(DatabaseContext context)
    {
        var products = context.Products.ToList();

        var customers = context.Customers.ToList();

        Console.WriteLine("Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.id} - {product.title} - {product.price:C} - {product.description} - {product.category}");
        }

        Console.WriteLine("\nCustomers:");
        foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.id} - {customer.name}");
        }
    }
}