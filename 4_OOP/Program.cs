using System;

Console.WriteLine("=== BELAJAR C# - 4: OOP ===");

Mobil mobilKu = new Mobil("Toyota","Avanza",2020);
mobilKu.NyalakanMesin();
mobilKu.InfoMobil();
mobilKu.MatikanMesin();
mobilKu.InfoMobil();

System.Console.WriteLine();

KendaraanElectric tesla = new KendaraanElectric("Tesla","Model 3",2023,85);
tesla.NyalakanMesin();
tesla.InfoMobil();
tesla.IsiDaya();

// 1. Encapsulation & Class
public class Mobil
{
    // field akses private (Encapsulation)
    private string _merek;
    private string _model;
    private int _tahun;

    // property publik dengan getter dan setter terkontrol
    public string Merek
    {
        get => _merek;
        set => _merek = value;
    }

    public string Model
    {
        get => _model;
        set => _model = value;
    }

    // Constructor untuk init object
    public Mobil(string merek, string model, int tahun)
    {
        _merek = merek;
        _model = model;
        _tahun = tahun;
    }

    // Method Perilaku (Behavior)
    public virtual void NyalakanMesin()
    {
        Console.WriteLine($"Mesin mobil {_merek} {_model} dinyalakan!!");
    }
    public void MatikanMesin()
    {
        Console.WriteLine($"Mesin mobil {_merek} dimatikan.");
    }

    public void InfoMobil()
    {
        Console.WriteLine($"[INFO] {_merek} {_model} keluaran tahun {_tahun}");
    }
}

// 2. Inheritance & Polymorphism
public class KendaraanElectric : Mobil
{
    public int KapasitasBateraiKWH{get;set;}

    // Constructor menggunakan base untuk inherit constructor parent
    public KendaraanElectric(string merek, string model, int tahun, int kapasitasBaterai)
        : base(merek, model, tahun)
    {
        KapasitasBateraiKWH = kapasitasBaterai;
    }

    // Polymorphism (override)
    public override void NyalakanMesin()
    {
        System.Console.WriteLine($"Mesin listrik {Merek} {Model} diaktifkan!");
    }

    public void IsiDaya()
    {
        System.Console.WriteLine($"Mengisi daya {Merek} {Model} hingga kapasitas {KapasitasBateraiKWH} kWh..");
    }
}