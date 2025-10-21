using Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Contracts;
using Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Models;

namespace Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Implementations;

public class ProductNameBuilder<SELF> : Builder<Product>
    where SELF : ProductNameBuilder<SELF>
{
    public SELF Called(string name)
    {
        Item.Name = name;
        return (SELF)this;
    }
}