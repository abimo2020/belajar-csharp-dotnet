using System;
using Humanizer;

Console.WriteLine("=== BELAJAR C# - 9: NUGET & .NET CLI");

// 1. Mengubah angka jadi kata-kata (Number Humanizer)
int angka = 1490;
System.Console.WriteLine($"Angka {angka} jika dibaca menjadi {angka.ToWords()}");

// 2. Format waktu relatif (DateTime Humanizer)
// Biasa digunakan di media sosial (ex: 3 jam yang lalu)
DateTime timeBefore = DateTime.UtcNow.AddHours(-3);
System.Console.WriteLine($"Waktu posting: {timeBefore.Humanize()}");

// 3. Mengubah format string
string rawWords = "aku_ingin_makan_kamu";
System.Console.WriteLine($"Original: {rawWords}");
System.Console.WriteLine($"Pascal: {rawWords.Pascalize()}");
System.Console.WriteLine($"Humanize: {rawWords.Humanize()}");

