using System;
using System.Collections.Generic;

Console.WriteLine("=== BELAJAR C# - 3: DATA COLLECTION ===");

// -------------------------------------------
// 1. ARRAY (Fixed Size)
// -------------------------------------------

Console.WriteLine("--- Array ---");
string[] listMahasiswa = {"Aryo Bimo", "Satrio Wibowo"};

Console.WriteLine($"Data pertama: {listMahasiswa[0]}");
listMahasiswa[0] = "Bimos";
Console.WriteLine($"Data pertama setelah diubah: {listMahasiswa[0]}");
Console.WriteLine($"Total mahasiswa {listMahasiswa.Length}");

// -------------------------------------------
// 2. LIST (Flexible)
// -------------------------------------------

List<string> listProgramLang = new List<string>{"Go","C#"};

listProgramLang.Add("PHP");
listProgramLang.Remove("Go");

Console.WriteLine("Daftar bahasa:");
foreach (var item in listProgramLang)
{
    Console.WriteLine($"Bahasa: {item}");
}
Console.WriteLine($"Total bahasa: {listProgramLang.Count}");

// -------------------------------------------
// 3. DICTIONARY (Key-value)
// -------------------------------------------

Dictionary<string, int> stockItem = new Dictionary<string, int>
{
    {"Kulkas",1},
    {"Lemari",10}
};
// Tambah data baru
stockItem.Add("Laptop",5);

// Akses data
Console.WriteLine($"Stok Laptop: {stockItem["Laptop"]}");

stockItem["Laptop"] = 9;

Console.WriteLine("Daftar stock barang:");
foreach(KeyValuePair<string,int> item in stockItem)
{
    Console.WriteLine($"- {item.Key}: {item.Value} unit");
}
