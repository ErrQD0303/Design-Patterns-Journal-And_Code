namespace Creational_Pattern_Builder_Lazy_Functional_Builder.Builder.Contracts;

public interface IBuilder<T>
where T : new()
{
    T Build();
}