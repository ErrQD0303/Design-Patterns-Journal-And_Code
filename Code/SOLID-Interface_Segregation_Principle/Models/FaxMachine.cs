using SOLID_Interface_Segregation_Principle.Contracts;

namespace SOLID_Interface_Segregation_Principle.Models;

public class FaxMachine : IFax
{
    public void Fax(string content, IFax destination)
    {
        Console.WriteLine("FaxMachine faxing: " + content);
    }
}