using Creational_Pattern_Builder_Lazy_Functional_Builder.Builder.Contracts;

namespace Creational_Pattern_Builder_Lazy_Functional_Builder.Builder;

public abstract class FunctionalBuilder<TSubject, TSelf> : IBuilder<TSubject>
where TSubject : new()
where TSelf : FunctionalBuilder<TSubject, TSelf>
{
    private List<Func<TSubject, TSubject>> Actions { get; } = [];

    public TSelf Do(Action<TSubject> action) => AddAction(action);

    public TSubject Build() => Actions.Aggregate(new TSubject(), (person, func) => func(person));

    private TSelf AddAction(Action<TSubject> action)
    {
        Actions.Add(model =>
        {
            action(model);
            return model;
        });

        return (TSelf)this;
    }

    public override string ToString()
    {
        return Build()?.ToString() ?? string.Empty;
    }

    public static implicit operator TSubject(FunctionalBuilder<TSubject, TSelf> builder) => builder.Build();
}