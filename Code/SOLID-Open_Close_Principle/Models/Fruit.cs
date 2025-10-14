namespace SOLID_Open_Close_Principle.Models;

public class Fruit
{
    public static int IdCounter { get; set; } = 1;

    public int Id { get; set; } = IdCounter++;
    public string Name { get; set; } = default!;
    public Color Color { get; set; } = default!;
    public FruitSize Size { get; set; } = default!;

    public override string ToString()
    {
        return $"{Id}:{Name}:{Color}:{Size}";
    }
}