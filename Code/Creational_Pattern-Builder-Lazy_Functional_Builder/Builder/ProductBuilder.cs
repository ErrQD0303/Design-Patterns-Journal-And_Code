using Creational_Pattern_Builder_Lazy_Functional_Builder.Builder.Contracts;
using Creational_Pattern_Builder_Lazy_Functional_Builder.Models;

namespace Creational_Pattern_Builder_Lazy_Functional_Builder.Builder;

public sealed class ProductBuilder : FunctionalBuilder<Product, ProductBuilder>, IProductBuilder<Product, ProductBuilder>
{
    public ProductBuilder Called(string name) => Do(product => product.Name = name);

    public ProductBuilder WithPrice(decimal price) => Do(product => product.Price = price);
}