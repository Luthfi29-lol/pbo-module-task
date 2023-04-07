// See https://aka.ms/new-console-template for more information
namespace laptop;
class Laptop
{
    public string Merk { get; set; }
    public string Tipe { get; set; }
    
    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop {0} {1} menyala", Merk, Tipe);
    }
    
    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop {0} {1} mati", Merk, Tipe);
    }
    
    public void BermainGame()
    {
        Console.WriteLine("Laptop {0} {1} sedang memainkan game", Merk, Tipe);
    }
    
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Vivobook : Laptop
{
    public string Vga { get; set; }
    public string Processor { get; set; }
    
    public Vivobook()
    {
        Merk = "Asus";
        Tipe = "Vivobook";
    }
}

class IdeaPad : Laptop
{
    public string Vga { get; set; }
    public string Processor { get; set; }
    
    public IdeaPad()
    {
        Merk = "Lenovo";
        Tipe = "IdeaPad";
    }
}

class Predator : Laptop
{
    public string Vga { get; set; }
    public string Processor { get; set; }
    
    public Predator()
    {
        Merk = "Acer";
        Tipe = "Predator";
    }
}
static void Main(string[] args)
{
    Laptop laptop1 = new Vivobook();
    laptop1.Vga = "Nvidia";
    laptop1.Processor = "Core i5";

    Laptop laptop2 = new IdeaPad();
    laptop2.Vga = "AMD";
    laptop2.Processor = "Ryzen";
    
    Predator predator = new Predator();
    predator.Vga = "AMD";
    predator.Processor = "Core i7";
    
    // melakukan beberapa aksi pada laptop1, laptop2, dan predator
    laptop1.LaptopDinyalakan();
    laptop1.BermainGame();
    laptop1.LaptopDimatikan();

    laptop2.LaptopDinyalakan();
    laptop2.Ngoding();
    laptop2.LaptopDimatikan();

    predator.LaptopDinyalakan();
    predator.BermainGame();
    predator.Ngoding();
    predator.LaptopDimatikan();
}

