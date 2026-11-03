using System;

Console.WriteLine("=== BELAJAR C# - 6: METHOD (FUNCTION) ===");

GreetUser("Aryo Bimo");

int resultMultiplication = Multiplicaton(2,3);
System.Console.WriteLine($"Hasil perkalian: {resultMultiplication}");

Logger("Get detail user");
Logger("No rows in result set", "ERROR");

int resultAddition = Addition(4,5);
System.Console.WriteLine($"Hasil pertambahan: {resultAddition}");

// 1. Method Void (tidak return value)
static void GreetUser(string name)
{
    System.Console.WriteLine($"Helo, selamat datang {name}..");
}

// 2. Method dengan return value
static int Multiplicaton(int a, int b)
{
    return a*b;
}

// 3. Method dengan optional parameter
static void Logger(string message, string level = "INFO")
{
    System.Console.WriteLine($"[{level}] {DateTime.Now:HH:mm:ss} - {message}");
}

// 4. Expression-Bodied Method (fungsi 1 baris)
static int Addition(int a, int b) => a +b;
