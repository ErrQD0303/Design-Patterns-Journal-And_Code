using Creational_Pattern_Builder.Contracts;

namespace Creational_Pattern_Builder.Models;

// I want to make a different version of Director class where I pass Builder as argument of a constructor method inside a class
public class Director
{
    public static IBuilder BuildMinimalViableProduct(IBuilder builder)
    {
        builder.BuildPartA();

        return builder;
    }

    public static IBuilder BuildFullFeaturedProduct(IBuilder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartC();

        return builder;
    }
}