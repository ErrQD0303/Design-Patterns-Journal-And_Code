namespace Creational_Pattern_Builder_SimpleBuilder;

public class HtmlBuilder
{
    private readonly string rootName;
    protected HtmlElement root = new();

    protected HtmlBuilder(string rootName)
    {
        this.rootName = rootName;
        root.Name = rootName;
    }

    public static HtmlBuilder Create(string rootName)
    {
        return new HtmlBuilder(rootName);
    }

    public HtmlBuilder AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        root.Elements.Add(e);

        return this;
    }

    public override string ToString()
    {
        return root.ToString();
    }
}