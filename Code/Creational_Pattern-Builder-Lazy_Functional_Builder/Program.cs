using Creational_Pattern_Builder_Lazy_Functional_Builder.Builder;
using Creational_Pattern_Builder_Lazy_Functional_Builder.Models;

Product product = new ProductBuilder()
    .Called("Beer Tiger")
    .WithPrice(1000);

Console.WriteLine(product);

var person = new PersonBuilder()
    .Called("Name")
    .WorkAt("CEO");

Console.WriteLine(person);

