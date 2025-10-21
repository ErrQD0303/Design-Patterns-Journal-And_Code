using System.Text;

namespace Creational_Pattern_Builder_Builder_Decorator;

public class CodeBuilder(int indentLevel = 0, int indentSize = 2)
{
    private StringBuilder SB { get; } = new();
    private int IndentLevel { get; set; } = indentLevel;
    private int IndentSize { get; set; } = indentSize;

    protected CodeBuilder Indent()
    {
        IndentLevel++;
        return this;
    }

    protected CodeBuilder IndentBack()
    {
        IndentLevel--;
        return this;
    }

    public CodeBuilder Scope(Action<CodeBuilder> builder)
    {
        AppendLine("{")
        .Indent();
        builder(this);
        return IndentBack().AppendLine("}");
    }

    public CodeBuilder Append(string? value = null)
    {
        SB.Append(' ', IndentLevel * IndentSize);
        SB.Append(value);
        return this;
    }

    public CodeBuilder AppendLine(string? line = null)
    {
        SB.Append(' ', IndentLevel * IndentSize);
        SB.AppendLine(line);
        return this;
    }

    public override string ToString()
    {
        return SB.ToString();
    }
}