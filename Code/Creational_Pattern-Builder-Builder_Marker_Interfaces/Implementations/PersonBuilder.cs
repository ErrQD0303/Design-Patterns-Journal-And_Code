using Creational_Pattern_Builder_Builder_Marker_Interfaces.Contracts;
using Creational_Pattern_Builder_Builder_Marker_Interfaces.Models;

namespace Creational_Pattern_Builder_Builder_Marker_Interfaces.Implementations;

public class PersonBuilder : IBuilder<Person>
{
    private Person Person { get; set; }

    public Person Build() => Person;

    protected PersonBuilder()
    {
        Person = new Person();
    }

    public static PersonBuilder Create()
    {
        return new PersonBuilder();
    }

    public PersonBuilder WithName(string name)
    {
        Person.Name = name;
        return this;
    }

    public PersonBuilder WithAge(int age)
    {
        Person.Age = age;
        return this;
    }

    public static implicit operator Person(PersonBuilder builder)
    {
        return builder.Build();
    }

    public override string ToString()
    {
        return Person.ToString();
    }
}