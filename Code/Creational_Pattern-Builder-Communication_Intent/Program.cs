using Creational_Pattern_Builder_SimpleBuilder;

var builder = HtmlElement
    .Create("ul")
    .AddChild("li", "hello")
    .AddChild("li", "world");
Console.WriteLine(builder.ToString());