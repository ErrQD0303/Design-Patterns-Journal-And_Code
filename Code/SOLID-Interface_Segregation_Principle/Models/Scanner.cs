using SOLID_Interface_Segregation_Principle.Contracts;

namespace SOLID_Interface_Segregation_Principle.Models;

public class Scanner : IScanner
{
    public void Scan(string content)
    {
        Console.WriteLine("Scanner scanning: " + content);
    }
}