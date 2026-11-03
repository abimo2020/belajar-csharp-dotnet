using System;
using System.Threading.Tasks;

Console.WriteLine("=== BELAJAR C# - 5: ASYNCHRONOUS PROGRAMMING ===");

var start = DateTime.Now;

System.Console.WriteLine("Sistem: memulai fetch data secara bersamaan..\n");

// 1. Menjalankan tugas proses async secara paralel
// Di Golang seperti menjalankan function dengan goroutine (go)
Task<string> taskUser = FetchUser();
Task<string> taskProduct = FetchProduct();

System.Console.WriteLine("Sistem: sambil menunggu data, sistem melakukan proses lain..");

// Simulasi pekerjaan selama 1 detik
await Task.Delay(1000);
System.Console.WriteLine("Sistem: proses lain sudah selesai");

// 2. Menunggu semua proses async selesai seperti sync.WaitGroup
await Task.WhenAll(taskUser,taskProduct);

// Mengambil hasil dari proses yang sudah selesai
System.Console.WriteLine(taskUser.Result);
System.Console.WriteLine(taskProduct.Result);

var totalTime = (DateTime.Now - start).TotalSeconds;
System.Console.WriteLine($"\n Semua proses telah selesai dalam total waktu: {totalTime:F2} detik.");

// ===============================================
// DEFINISI METHOD ASYNC
// ===============================================

async Task<string> FetchUser()
{
    System.Console.WriteLine("[DB]: Simulasi mengambil data user selama 1,5 detik");
    await Task.Delay(1500);
    return "[DB]: Sukses mengambil data user ['Aryo Bimo', 'Backend Engineer']";
}

async Task<string> FetchProduct()
{
    System.Console.WriteLine($"[DB]: Simulasi mengambil data product selama 2 detik");
    await Task.Delay(2000);
    return "[DB]: Sukses mengambil data product ['Kulkas','Mobil']";
}
