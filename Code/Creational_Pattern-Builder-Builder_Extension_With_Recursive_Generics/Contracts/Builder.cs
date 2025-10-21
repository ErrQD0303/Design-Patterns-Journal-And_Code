namespace Creational_Pattern_Builder_Builder_Extension_With_Recursive_Generics.Contracts;

public abstract class Builder<T> where T : class, new()
{
    protected T Item { get; }

    public Builder()
    {
        Item = new();
    }

    public T Build() => Item;
}