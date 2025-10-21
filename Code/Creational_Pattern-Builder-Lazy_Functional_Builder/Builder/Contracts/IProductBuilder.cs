using Creational_Pattern_Builder_Lazy_Functional_Builder.Models;

namespace Creational_Pattern_Builder_Lazy_Functional_Builder.Builder.Contracts;

public interface IProductBuilder<TSubject, TSelf>
    where TSelf : FunctionalBuilder<TSubject, TSelf>
    where TSubject : new()
{
    TSelf Called(string name);
    TSelf WithPrice(decimal price);
}