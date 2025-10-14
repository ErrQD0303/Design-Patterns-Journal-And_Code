using SOLID_Open_Close_Principle.Contracts;
using SOLID_Open_Close_Principle.Models;

namespace SOLID_Open_Close_Principle.Implementations;

/// <summary>
/// Specification for filtering colors.
/// </summary>
/// <param name="color">The Color</param>
public class ColorSpecification(Color color) : Specification<Fruit>
{
    private Color Color { get; init; } = color;

    public override bool IsSatisfied(Fruit item)
    {
        return Color.HexCode == item.Color.HexCode;
    }
}