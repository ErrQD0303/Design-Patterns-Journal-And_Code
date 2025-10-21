using Creational_Pattern_Builder_Builder_Marker_Interfaces.Contracts;
using Creational_Pattern_Builder_Builder_Marker_Interfaces.Implementations;

namespace Creational_Pattern_Builder_Builder_Marker_Interfaces.Models;

public class Person : IBuildableUsing<PersonBuilder, Person>
{
    public string Id = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = default;

    public static PersonBuilder New => PersonBuilder.Create();

    public override string ToString()
    {
        return $"Person: Id={Id}, Name={Name}, Age={Age}";
    }
}