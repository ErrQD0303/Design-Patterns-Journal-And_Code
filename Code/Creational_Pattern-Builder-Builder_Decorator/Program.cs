using Creational_Pattern_Builder_Builder_Decorator;

var cb = new CodeBuilder();

cb.AppendLine("public void PrintHelloWorld()")
    .Scope(codeBuilder => codeBuilder.AppendLine("Console.WriteLine(\"Hello World\");"));

Console.WriteLine(cb);