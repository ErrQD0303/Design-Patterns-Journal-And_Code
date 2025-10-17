using Creational_Pattern_Builder.Contracts;

namespace Creational_Pattern_Builder.Models;

public class ConcreteBuilder : IBuilder
{
    private Product Product { get; set; } = new();

    public ConcreteBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        Product = new();
    }

    public void BuildPartA()
    {
        Product.Add("PartA1");
    }

    public void BuildPartB()
    {
        Product.Add("PartB1");
    }

    public void BuildPartC()
    {
        Product.Add("PartC1");
    }

    public Product GetProduct()
    {
        Product result = Product;
        // Each time product is retrieved, a new builder instance is created to work with a fresh product instance next time.
        Reset();

        return result;
    }
}