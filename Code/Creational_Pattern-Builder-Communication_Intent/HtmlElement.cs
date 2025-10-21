using System.ComponentModel.Design.Serialization;
using System.Text;

namespace Creational_Pattern_Builder_SimpleBuilder;

public class HtmlElement
{
    public string Name { get; set; }
    public string Text { get; set; }
    private readonly Lazy<List<HtmlElement>> _elements = new();
    public IReadOnlyList<HtmlElement> Elements => _elements.Value;
    private const int indentSize = 2;

    protected HtmlElement(string name, string text)
    {
        Name = name;
        Text = text;
    }

    protected HtmlElement() : this(string.Empty, string.Empty)
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

    public static HtmlBuilder Create(string rootName)
    {
        return HtmlBuilder.Create(rootName);
    }

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
            root._elements.Value.Add(e);

            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public HtmlElement Build() => root;

        public static implicit operator HtmlElement(HtmlBuilder builder) => builder.Build();
    }
}