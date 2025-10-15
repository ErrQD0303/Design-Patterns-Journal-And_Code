using SOLID_Interface_Segregation_Principle.Contracts;

namespace SOLID_Interface_Segregation_Principle.Models;

public class MultiFunctionDeviceParameterObject
{
    public IPrinter? Printer { get; set; } = default!;
    public IFax? FaxMachine { get; set; } = default!;
    public IScanner? Scanner { get; set; } = default!;
}