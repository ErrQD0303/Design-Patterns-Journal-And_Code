using Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Models;

namespace Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Implementations;

public class ProductSizeBuilder<SELF> : ProductNameBuilder<ProductSizeBuilder<SELF>>
    where SELF : ProductSizeBuilder<SELF>
{
    public SELF HaveSize(ProductSize size)
    {
        Item.Size = size;
        return (SELF)this;
    }
}