using Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Models;

namespace Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Implementations;

public class ProductTypeBuilder<SELF> : ProductSizeBuilder<ProductTypeBuilder<SELF>>
    where SELF : ProductTypeBuilder<SELF>
{
    public SELF WithType(ProductType type)
    {
        Item.Type = type;
        return (SELF)this;
    }
}