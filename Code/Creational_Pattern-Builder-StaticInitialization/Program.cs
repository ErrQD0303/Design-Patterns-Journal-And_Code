using Creational_Pattern_Builder_SimpleBuilder;

var builder = HtmlBuilder.Create("ul")
    .AddChild("li", "hello")
    .AddChild("li", "world");
Console.WriteLine(builder.ToString());