using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// 1. Mendaftarkan service ke DI Container (Dependecies Injection)
// Menggunakan singleton agar data tetap tersimpan selama aplikasi masih berjalan
builder.Services.AddSingleton<IProductService, ProductService>();

var app = builder.Build();

app.MapGet("/api/product",(IProductService productService) => {
   var data = productService.GetProductList();
   return Results.Ok(new
   {
       status = "success",
       data = data
   });
});

app.MapPost("/api/product", ([FromBody]string name,IProductService productService) =>
{
    if (string.IsNullOrWhiteSpace(name))
    {
        return Results.BadRequest(new {message = "Nama produk tidak boleh kosong"});
    }    
    productService.AddProduct(name);

    return Results.Created($"/api/product", new {message = "Produk berhasil dibuat.", product = name});
});

app.Run();

// ===============================================
// DEFINISI SERVICE & INTERFACE
// ===============================================

public interface IProductService
{
    List<string> GetProductList();
    void AddProduct(string name);
}

public class ProductService : IProductService
{
    private readonly List<string> _dbSimulation = new()
    {
        "Lenovo Legion 5",
        "Lenovo Thinkpad T14s",
        "Macbook Air M1"
    };

    public List<string> GetProductList() => _dbSimulation;

    public void AddProduct(string name) => _dbSimulation.Add(name);
} 