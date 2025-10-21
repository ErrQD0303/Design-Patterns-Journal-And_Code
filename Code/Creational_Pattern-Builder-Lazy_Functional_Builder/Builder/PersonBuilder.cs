using Creational_Pattern_Builder_Lazy_Functional_Builder.Builder.Contracts;
using Creational_Pattern_Builder_Lazy_Functional_Builder.Models;

namespace Creational_Pattern_Builder_Lazy_Functional_Builder.Builder;

public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>, IPersonBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name) => Do(person => person.Name = name);

    public PersonBuilder WorkAt(string position) => Do(person => person.Position = position);
}