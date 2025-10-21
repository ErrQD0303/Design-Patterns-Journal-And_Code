using Creational_Pattern_Builder_SimpleBuilder;

var builder = new HtmlBuilder("ul")
    .AddChild("li", "hello")
    .AddChild("li", "world");
Console.WriteLine(builder.ToString());