namespace Creational_Pattern_Builder_Lazy_Functional_Builder.Models;

public class Product
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"Product - Name: {Name}, Price: {Price}";
    }
}