using SOLID_Interface_Segregation_Principle.Contracts;

namespace SOLID_Interface_Segregation_Principle.Models;

public class Printer : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine("Printer printing: " + content);
    }
}