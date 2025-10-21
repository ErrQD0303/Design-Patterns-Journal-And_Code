using Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Models;

var product = Product.New
    .Called("Tiger")
    .HaveSize(ProductSize.Small)
    .WithType(ProductType.Beverage)
    .Build();

Console.WriteLine(product);

