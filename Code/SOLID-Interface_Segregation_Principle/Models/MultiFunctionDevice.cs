using SOLID_Interface_Segregation_Principle.Contracts;

namespace SOLID_Interface_Segregation_Principle.Models;

public class MultiFunctionDevice : IMultifunctionDevice
{
    private IPrinter Printer { get; init; }
    private IFax FaxMachine { get; init; }
    private IScanner Scanner { get; init; }

    public MultiFunctionDevice(MultiFunctionDeviceParameterObject obj)
    {
        ArgumentNullException.ThrowIfNull(obj);

        Printer = obj.Printer ?? throw new ArgumentNullException(nameof(obj.Printer));
        FaxMachine = obj.FaxMachine ?? throw new ArgumentNullException(nameof(obj.FaxMachine));
        Scanner = obj.Scanner ?? throw new ArgumentNullException(nameof(obj.Scanner));
    }

    public void Fax(string content, IFax destination)
    {
        FaxMachine.Fax(content, destination);
    }

    public void Print(string content)
    {
        Printer.Print(content);
    }

    public void Scan(string content)
    {
        Scanner.Scan(content);
    }
}