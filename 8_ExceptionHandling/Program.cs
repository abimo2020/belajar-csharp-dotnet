using System;

Console.WriteLine("=== BELAJAR C# - 8: EXCEPTION HANDLING ===");

// Contoh 1
try
{
    System.Console.WriteLine("Masukkan angka pembilang:");
    string inputPembilang = Console.ReadLine();
    int pembilang = int.Parse(inputPembilang);

    System.Console.WriteLine("Masukkan angka penyebut");
    string inputPenyebut = Console.ReadLine();
    int penyebut = int.Parse(inputPenyebut);

    int hasil = DivideNumber(pembilang,penyebut);
    System.Console.WriteLine($"Hasil pembagian: {hasil}");
}
catch (FormatException)
{
    System.Console.WriteLine("[ERROR] Input harus berupa angka yang valid!");
}catch(DivideByZeroException ex)
{
    System.Console.WriteLine($"[ERROR] Terjadi kesalahan matematika: {ex.Message}");
}catch(Exception ex)
{
    System.Console.WriteLine($"[CRITICAL ERROR] Terjadi kesalahan tidak terduga: {ex.Message}");
}
finally
{
    System.Console.WriteLine("[INFO] Blok ini akan selalu dieksekusi baik error atau tidak..");
}

// Contoh 2 Custom Exception
try
{
    CreateTransaction(-10000);
}catch(ArgumentException ex)
{
    System.Console.WriteLine($"[VALIDASI ERROR] {ex.Message}");
}


// ===================
// DEFINISI METHOD
// ===================

static int DivideNumber(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Penyebut tidak boleh dibagi 0");
    }
    return a/b;
}

static void CreateTransaction(decimal nominal)
{
    if (nominal <= 0)
    {
        throw new ArgumentException("Nominal transaksi harus lebih dari 0");
    }
    System.Console.WriteLine($"Transaksi sebesar Rp. {nominal:N0} berhasil diproses");
}