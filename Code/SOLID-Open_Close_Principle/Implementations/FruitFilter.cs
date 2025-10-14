using SOLID_Open_Close_Principle.Contracts;
using SOLID_Open_Close_Principle.Models;

namespace SOLID_Open_Close_Principle.Implementations;

public class FruitFilter : IFilter<Fruit>
{
    public IEnumerable<Fruit> Filter(IEnumerable<Fruit> items, Specification<Fruit> spec)
    {
        foreach (var item in items)
        {
            if (spec.IsSatisfied(item))
            {
                yield return item;
            }
        }
    }
}