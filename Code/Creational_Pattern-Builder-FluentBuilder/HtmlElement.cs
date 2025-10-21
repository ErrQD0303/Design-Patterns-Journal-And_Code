using System.Text;

namespace Creational_Pattern_Builder_SimpleBuilder;

public record HtmlElement(string Name, string Text)
{
    public string Name { get; set; } = Name;
    public string Text { get; set; } = Text;
    private readonly Lazy<List<HtmlElement>> _elements = new();
    public List<HtmlElement> Elements => _elements.Value;
    private const int indentSize = 2;

    public HtmlElement() : this(string.Empty, string.Empty)
    {

    }

    public override string ToString()
    {
        return ToStringImpl(0);
    }

    private string ToStringImpl(int indent)
    {
        var sb = new StringBuilder();
        var i = new string(' ', indentSize * indent);
        sb.AppendLine($"{i}<{Name}>");

        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', indentSize * (indent + 1)));
            sb.AppendLine(Text);
        }

        foreach (var e in Elements)
        {
            sb.Append(e.ToStringImpl(indent + 1));
        }

        sb.AppendLine($"{i}</{Name}>");
        return sb.ToString();
    }
}