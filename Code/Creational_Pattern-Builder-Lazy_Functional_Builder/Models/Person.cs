namespace Creational_Pattern_Builder_Lazy_Functional_Builder.Models;

public class Person
{
    public string Name { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Person - Name: {Name}, Position: {Position}";
    }
}