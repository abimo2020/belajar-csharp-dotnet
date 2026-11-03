using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("=== BELAJAR C# - 7: Language Integrated Query (LINQ) ===");

// Data Dummy
List<Product> productList = new List<Product>
{
    new Product{Id = 1, Name = "Legion Y540", Category = "Laptop", Price = 15000000, Stock = 4},
    new Product{Id = 2, Name = "Macbook M2", Category = "Laptop", Price = 2000000, Stock = 2},
    new Product{Id = 3, Name = "Logitech MX Master 3S", Category = "Accessories", Price = 200000, Stock = 10},
    new Product{Id = 4, Name = "Mechanical Keyboard Keychron", Category = "Accessories", Price = 150000, Stock = 0},
    new Product{Id = 5, Name = "Monitor Dell 24 inch", Category = "Monitor", Price = 500000, Stock = 8}
};

// 1. Where: Filtering
var laptopList = productList.Where(p => p.Category == "Laptop").ToList();

System.Console.WriteLine("\n--- DAFTAR LAPTOP (WHERE) ---");
foreach(var p in laptopList)
{
    System.Console.WriteLine($"- {p.Name} - (Rp. {p.Price:N0})");
}

// 2. Select: Memetakan/Transformasi data (Projection)
var productName = productList.Select(p => p.Name).ToList();
System.Console.WriteLine("\n--- NAMA PRODUCT (SELECT) ---");
foreach(var p in productList)
{
    System.Console.WriteLine($"- {p.Name}");
}

// 3. OrderBy: Sorting
var mostExpensiveProduct = productList.OrderByDescending(p => p.Price);
System.Console.WriteLine("\n--- URUTAN TERMAHAL (ORDER BY) ---");
foreach(var p in mostExpensiveProduct)
{
    System.Console.WriteLine($"- {p.Name} (Rp. {p.Price:N0})");
}

// 4. Any & FirstOrDefault: pencarian kondisi khusus
// cek apakah ada barang yang habis
bool isOutOfStock = productList.Any(p => p.Stock == 0);
System.Console.WriteLine("\n--- CEK STOCK HABIS (ANY ---");
System.Console.WriteLine($"Apakah ada barang yang habis stocknya? {(isOutOfStock?"Ya":"Tidak")}");

// Cari produk dengan harga lebih dari 10 juta
var firstProductExpensive = productList.FirstOrDefault(p => p.Price > 10000000);
if (firstProductExpensive != null)
{
    System.Console.WriteLine($"Produk > 10 juta pertama: {firstProductExpensive.Name}");
}

// -------------------------------
// DEFINISI MODEL CLASS
// -------------------------------

public class Product
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Category{get;set;}
    public decimal Price{get;set;}
    public int Stock{get;set;}
}