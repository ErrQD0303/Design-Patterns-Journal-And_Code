using Creational_Pattern_Builder_Builder_Marker_Interfaces.Contracts;
using Creational_Pattern_Builder_Builder_Marker_Interfaces.Implementations;

namespace Creational_Pattern_Builder_Builder_Marker_Interfaces.Models;

public class Product : IBuildableUsing<ProductBuilder, Product>
{
    public string Id = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public float Price { get; set; } = default;

    public static ProductBuilder New => ProductBuilder.Create();

    public override string ToString()
    {
        return $"Product: Id={Id}, Name={Name}, Price={Price}";
    }
}