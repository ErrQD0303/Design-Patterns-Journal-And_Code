using SOLID_Open_Close_Principle.Contracts;
using SOLID_Open_Close_Principle.Models;

namespace SOLID_Open_Close_Principle.Implementations;

/// <summary>
/// Specification for filtering sizes.
/// </summary>
/// <param name="size">The Fruit Size</param>
public class SizeSpecification(FruitSize size) : Specification<Fruit>
{
    private FruitSize Size { get; init; } = size;

    public override bool IsSatisfied(Fruit item)
    {
        return Size == item.Size;
    }
}