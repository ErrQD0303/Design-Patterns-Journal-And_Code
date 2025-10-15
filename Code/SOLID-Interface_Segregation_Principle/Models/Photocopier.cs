using SOLID_Interface_Segregation_Principle.Contracts;

namespace SOLID_Interface_Segregation_Principle.Models;

public class Photocopier : IPrinter, IScanner
{
    public void Print(string content)
    {
        Console.WriteLine("Photocopier printing: " + content);
    }

    public void Scan(string content)
    {
        Console.WriteLine("Photocopier scanning: " + content);
    }
}