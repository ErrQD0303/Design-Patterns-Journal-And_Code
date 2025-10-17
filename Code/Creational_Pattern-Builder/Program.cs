// The client code creates a builder object, passes it to the
// director and then initiates the construction process. The end
// result is retrieved from the builder object.
using Creational_Pattern_Builder.Models;

var builder = new ConcreteBuilder();

Console.WriteLine("Standard basic product:");
Director.BuildMinimalViableProduct(builder);
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard full featured product:");
Director.BuildFullFeaturedProduct(builder);
Console.WriteLine(builder.GetProduct().ListParts());

// Remember, the Builder pattern can be used without a Director
// class.
Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.Write(builder.GetProduct().ListParts());