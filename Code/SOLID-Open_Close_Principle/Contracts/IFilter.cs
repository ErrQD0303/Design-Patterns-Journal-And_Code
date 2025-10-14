namespace SOLID_Open_Close_Principle.Contracts;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
}