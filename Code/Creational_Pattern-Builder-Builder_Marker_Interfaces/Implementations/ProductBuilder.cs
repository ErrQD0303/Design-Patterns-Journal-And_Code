using Creational_Pattern_Builder_Builder_Marker_Interfaces.Contracts;
using Creational_Pattern_Builder_Builder_Marker_Interfaces.Models;

namespace Creational_Pattern_Builder_Builder_Marker_Interfaces.Implementations;

public class ProductBuilder : IBuilder<Product>
{
    private Product Product { get; set; }
    public Product Build() => Product;

    protected ProductBuilder()
    {
        Product = new Product();
    }

    public static ProductBuilder Create()
    {
        return new ProductBuilder();
    }

    public ProductBuilder WithName(string name)
    {
        Product.Name = name;
        return this;
    }

    public ProductBuilder WithPrice(float price)
    {
        Product.Price = price;
        return this;
    }

    public static implicit operator Product(ProductBuilder builder)
    {
        return builder.Build();
    }

    public override string ToString()
    {
        return Product.ToString();
    }
}