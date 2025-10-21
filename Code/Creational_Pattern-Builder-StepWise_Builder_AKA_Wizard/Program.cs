using Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Enums;
using Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Models;
using ProductBuilder = Creational_Pattern_Builder_StepWise_Builder_AKA_Wizard.Models.Product.ProductBuilder;

Product product = ProductBuilder.Create()
    .WithName("Tiger")
    .WithPrice(99.99m)
    .WithType(ProductType.Beverage)
    .Build();

Console.WriteLine(product);