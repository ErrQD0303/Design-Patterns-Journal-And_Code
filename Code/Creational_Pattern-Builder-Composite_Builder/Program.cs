using Creational_Pattern_Builder_Composite_Builder;
using DrinkBuilder = Creational_Pattern_Builder_Composite_Builder.Drink.DrinkBuilder;

var drink = DrinkBuilder.Create("Tiger")
    .Info
        .SetType(DrinkType.Beer)
        .SetSize(DrinkSize.Large)
    .Ingredients
        .AddAlcohol().Build();

Console.WriteLine(drink);