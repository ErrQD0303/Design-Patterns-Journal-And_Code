namespace Creational_Pattern_Builder.Models;

public class Product
{
    private List<object> Part { get; set; } = [];

    public void Add(string part)
    {
        Part.Add(part);
    }

    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < Part.Count; i++)
        {
            str += Part[i] + ", ";
        }

        str = str[..^2]; // removing last ", "

        return "Product parts: " + str + "\n";
    }
}