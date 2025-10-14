using SOLID_Open_Close_Principle.Contracts;

namespace SOLID_Open_Close_Principle.Implementations;

public class AndSpecification<T>(Specification<T> first, Specification<T> second) : Specification<T>
{
    private Specification<T> First { get; init; } = first;
    private Specification<T> Second { get; init; } = second;

    public override bool IsSatisfied(T item)
    {
        return First.IsSatisfied(item) && Second.IsSatisfied(item);
    }
}