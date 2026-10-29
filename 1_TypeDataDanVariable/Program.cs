Console.WriteLine("=== BELAJAR C# - 1: TYPE DATA DAN VARIABEL ===");

// Type data deklaratif dan explicit
int age = 20;
double height = 172.2;
char initial = 'A';
bool isProgrammer = true;
string fullName = "Aryo Bimo";

// Implicit typing
var city = "Blitar";
var weight = 60.50;

// String interpolation menggunakan '$'
Console.WriteLine($"Nama            : {fullName} ({initial})");
Console.WriteLine($"Umur            : {age}");
Console.WriteLine($"Kota            : {city}");
Console.WriteLine($"Tinggi/Berat    : {height}/{weight} kg");
Console.WriteLine($"Status          : {(isProgrammer?"Programmer":"Non-Programmer")}");

// Input
Console.WriteLine("Masukkan bahasa anda..");
string? language = Console.ReadLine();
Console.WriteLine($"Bahasa yang anda gunakan adalah {language}");