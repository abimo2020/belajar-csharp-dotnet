Console.WriteLine("=== BELAJAR C# - 2: CONTROL FLOW");

// -------------------------------------------
// 1. PERCABANGAN (If-Else & Switch Expression)
// -------------------------------------------
Console.WriteLine("Masukkan nilai ujian (0-100):");
string? inputNilai = Console.ReadLine();

if (int.TryParse(inputNilai,out int nilai))
{   
    // if else klasik
    if (nilai > 80)
    {
        Console.WriteLine("Predikat: Sangat Baik");
    }
    else if(nilai >= 60)
    {
        Console.WriteLine("Predikat: Cukup Baik");
    }
    else
    {
        Console.WriteLine("Predikat: Kurang Baik");
    }

    // switch expression
    string grade = nilai switch
    {
        >= 80 => "A",
        >= 60 => "B",
        _ => "C" // "_" merupakan wildcard / default case
    };
    
    Console.WriteLine($"Grade Nilai: {grade}");
}
else
{
    Console.WriteLine("Input tidak valid!");
}


// -------------------------------------------
// 2. PERULANGAN (For, While, Foreach)
// -------------------------------------------
Console.WriteLine("\n--- Perulangan For ---");
for (int i = 1;i <= 3; i++)
{
    Console.WriteLine($"Interasi ke-{i}");
}

Console.WriteLine("\n--- Perulangan Foreach ---");
string[] daftarMahasiswa = ["Aryo Bimo","Satrio Wibowo"];

foreach(var mahasiswa in daftarMahasiswa)
{
    Console.WriteLine($"Nama mahasiswa: {mahasiswa}");
}

Console.WriteLine("\n--- Perulangan While  ---");
int counter = 0;

while (true)
{
    counter++;
    
    if (counter%2 == 0)
    {
        continue;
    }

    Console.WriteLine($"Angka Ganjil: {counter}");

    if (counter> 5)
    {
        break;
    }
}