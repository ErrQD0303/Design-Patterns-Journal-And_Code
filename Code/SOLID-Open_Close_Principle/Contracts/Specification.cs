using SOLID_Open_Close_Principle.Implementations;

namespace SOLID_Open_Close_Principle.Contracts;

public abstract class Specification<T>
{
    public abstract bool IsSatisfied(T item);

    public static Specification<T> operator &(Specification<T> first, Specification<T> second)
    {
        return new AndSpecification<T>(first, second);
    }

    public static Specification<T> operator |(Specification<T> first, Specification<T> second)
    {
        return new OrSpecification<T>(first, second);
    }
}