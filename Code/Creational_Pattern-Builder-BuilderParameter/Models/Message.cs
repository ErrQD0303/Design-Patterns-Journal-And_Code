using Creational_Pattern_Builder_BuilderParameter.Contracts;

namespace Creational_Pattern_Builder_BuilderParameter.Models;

public class Message
{
    public IMessagePublisher From { get; set; } = default!;
    public IMessageReceiver To { get; set; } = default!;
    public string Subject { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
}