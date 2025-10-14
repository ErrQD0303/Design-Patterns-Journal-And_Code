namespace SOLID_Open_Close_Principle.Models;

public class Color
{
    public string Name { get; set; } = default!;
    public string HexCode { get; set; } = default!;

    public override string ToString()
    {
        return $"{Name}-{HexCode}";
    }
}