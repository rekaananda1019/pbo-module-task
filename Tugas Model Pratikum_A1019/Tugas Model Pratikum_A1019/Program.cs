using System;

// Class Processor
class Processor
{
    public string Merk { get; set; }
    public string Tipe { get; set; }
}

// Subclass Intel
class Intel : Processor
{
    public Intel()
    {
        Merk = "Intel";
    }
}

// Subclass AMD
class AMD : Processor
{
    public AMD()
    {
        Merk = "AMD";
    }
}

// Subclass dari Intel
class Corei3 : Intel
{
    public Corei3()
    {
        Tipe = "Core i3";
    }
}

class Corei5 : Intel
{
    public Corei5()
    {
        Tipe = "Core i5";
    }
}

class Corei7 : Intel
{
    public Corei7()
    {
        Tipe = "Core i7";
    }
}

// Subclass dari AMD
class Ryzen : AMD
{
    public Ryzen()
    {
        Tipe = "RYZEN";
    }
}

class Athlon : AMD
{
    public Athlon()
    {
        Tipe = "ATHLON";
    }
}

// Class Vga
class Vga
{
    public string Merk { get; set; }
}

// Subclass Nvidia
class Nvidia : Vga
{
    public Nvidia()
    {
        Merk = "Nvidia";
    }
}

// Subclass AMD
class AMDVga : Vga
{
    public AMDVga()
    {
        Merk = "AMD";
    }
}

// Class Laptop
class Laptop
{
    public string Merk { get; set; }
    public string Tipe { get; set; }
    public Vga Vga { get; set; }
    public Processor Processor { get; set; }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }
}

// Subclass Asus
class Asus : Laptop
{
    public Asus()
    {
        Merk = "ASUS";
    }
}

// Subclass Acer
class Acer : Laptop
{
    public Acer()
    {
        Merk = "ACER";
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }
}

// Subclass Lenovo
class Lenovo : Laptop
{
    public Lenovo()
    {
        Merk = "Lenovo";
    }
}

// Subclass dari Asus
class Rog : Asus
{
    public Rog()
    {
        Tipe = "ROG";
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Vivobook : Asus
{
    public Vivobook()
    {
        Tipe = "Vivobook";
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

// Subclass dari Acer
class Swift : Acer
{
    public Swift()
    {
        Tipe = "Swift";
    }
}

class Predator : Acer
{
    public Predator()
    {
        Tipe = "Predator";
    }
}

// Subclass dari Lenovo
class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        Tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        Tipe = "Legion";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek laptop1 dengan Vivobook, Vga Nvidia, dan Processor Core i5
        var laptop1 = new Vivobook
        {
            Vga = new Nvidia(),
            Processor = new Corei5()
        };

        // Membuat objek laptop2 dengan IdeaPad, Vga AMD, dan Processor Ryzen
        var laptop2 = new IdeaPad
        {
            Vga = new AMDVga(),
            Processor = new Ryzen()
        };

        // Membuat objek predator dengan Predator, Vga AMD, dan Processor Core i7
        //var predator = new Predator
        {
            //Vga = new AMDVga(),
            //Processor = new Corei7()
        };

        // Soal nomer 5
        // Membuat objek acer dengan Predator, Vga AMD, dan Processor Core i7
        var acer = new Acer
        {
            Vga = new AMDVga(),
            Processor = new Corei7(),
            Tipe = "Predator" // Anda perlu mengatur tipe laptop pada objek Predator
        };

        // Bermain game dengan acer (Predator)
        acer.BermainGame();

    // Soal nomer 3
    // Menampilkan spesifikasi laptop1
    //Console.WriteLine("Spesifikasi Laptop 1:");
    //Console.WriteLine($"Merk VGA: {laptop1.Vga.Merk}");
    //Console.WriteLine($"Merk Processor: {laptop1.Processor.Merk}");
    //Console.WriteLine($"Tipe Processor: {laptop1.Processor.Tipe}");


    // Menyalakan dan mematikan laptop1
    //laptop1.LaptopDinyalakan();
    //laptop1.LaptopDimatikan();

    // Menyalakan dan mematikan laptop2
    //laptop2.LaptopDinyalakan();
    //laptop2.LaptopDimatikan();

    // Bermain game dengan predator
    //predator.BermainGame();

        // Ngoding dengan Vivobook
        //laptop1.Ngoding();
    }
}
