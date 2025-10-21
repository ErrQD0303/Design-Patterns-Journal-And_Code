namespace Creational_Pattern_Builder_BuilderParameter.Contracts;

public interface IMessageBuilder
{
    IMessageBuilder WithSubject(string subject);
    IMessageBuilder WithText(string text);
}