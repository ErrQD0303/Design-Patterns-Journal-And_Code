using Creational_Pattern_Builder_Builder_Marker_Interfaces.Models;

var product = Product.New
    .WithName("Laptop")
    .WithPrice(1500.0f);

Console.WriteLine(product);

var person = Person.New
    .WithName("Alice")
    .WithAge(28);

Console.WriteLine(person);