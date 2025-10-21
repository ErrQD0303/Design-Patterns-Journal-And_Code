using Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Implementations;

namespace Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Models;

public class Product
{
    public string Name { get; set; } = string.Empty;
    public ProductType Type { get; set; } = ProductType.NotSet;
    public ProductSize Size { get; set; } = ProductSize.NotDefined;

    public Product() { }

    public static Builder New => new();

    public class Builder : ProductTypeBuilder<Builder>
    {
        internal Builder() { }

        public override string ToString()
        {
            return Item.ToString();
        }

        public static implicit operator Product(Builder builder) => builder.Item;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Type: {Type}, Size: {Size}";
    }
}
