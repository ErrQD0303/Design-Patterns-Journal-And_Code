using SOLID_Open_Close_Principle.Implementations;
using SOLID_Open_Close_Principle.Models;

var fruitBasket = new List<Fruit>
{
    new() {
        Name = "Apple",
        Color = new Color
        {
            Name = "Yellow",
            HexCode = "#FFFF00"
        },
        Size = FruitSize.Medium
    },
    new() {
        Name = "Banana",
        Color = new Color
        {
            Name = "Yellow",
            HexCode = "#FFFF00"
        },
        Size = FruitSize.Medium
    },
    new() {
        Name = "Grapes",
        Color = new Color
        {
            Name = "Purple",
            HexCode = "#800080"
        },
        Size = FruitSize.Small
    },
    new() {
        Name = "Orange",
        Color = new Color
        {
            Name = "Orange",
            HexCode = "#FFA500"
        },
        Size = FruitSize.Medium
    },
    new() {
        Name = "Blueberry",
        Color = new Color
        {
            Name = "Blue",
            HexCode = "#0000FF"
        },
        Size = FruitSize.Small
    }
};

var fruitFilter = new FruitFilter();

Console.WriteLine("Fruits that are Yellow:");
foreach (var fruit in fruitFilter.Filter(fruitBasket, new ColorSpecification(new Color { Name = "Yellow", HexCode = "#FFFF00" })))
{
    Console.WriteLine(fruit);
}

Console.WriteLine("\nFruits that are Small:");
foreach (var fruit in fruitFilter.Filter(fruitBasket, new SizeSpecification(FruitSize.Small)))
{
    Console.WriteLine(fruit);
}

Console.WriteLine("\nFruits that are Medium and Yellow:");
foreach (var fruit in fruitFilter.Filter(fruitBasket, new SizeSpecification(FruitSize.Medium) & new ColorSpecification
(new Color
{
    Name = "Yellow",
    HexCode = "#FFFF00"
})))
{
    Console.WriteLine(fruit);
}

Console.WriteLine("\nFruits that are either Medium or Yellow:");
foreach (var fruit in fruitFilter.Filter(fruitBasket, new SizeSpecification(FruitSize.Medium) | new ColorSpecification
(new Color
{
    Name = "Yellow",
    HexCode = "#FFFF00"
})))
{
    Console.WriteLine(fruit);
}