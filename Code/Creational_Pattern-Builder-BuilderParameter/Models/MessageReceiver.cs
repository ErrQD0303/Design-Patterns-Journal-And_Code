using Creational_Pattern_Builder_BuilderParameter.Contracts;

namespace Creational_Pattern_Builder_BuilderParameter.Models;

public class MessageReceiver(string name) : IMessageReceiver
{
    public string Name { get; set; } = name;

    private void PrintPublisherMessage(Message message)
    {
        message.To = this;

        Console.WriteLine($"Receiver {this} receive a message from {message.From}");
        Console.WriteLine($"Subject: {message.Subject}");
        Console.WriteLine($"Text: \n{message.Text}");
    }

    public void SubscribeTo(IMessagePublisher publisher)
    {
        publisher.AddReceiver(PrintPublisherMessage);
    }

    public override string ToString()
    {
        return $"Receiver {{{Name}}}";
    }
}