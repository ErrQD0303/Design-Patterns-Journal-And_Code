namespace Creational_Pattern_Builder_Builder_Marker_Interfaces.Contracts;

public interface IBuildableUsing<out TBuilder, TSubject>
    where TBuilder : IBuilder<TSubject>
    where TSubject : class
{
    static TBuilder? New { get; }
}