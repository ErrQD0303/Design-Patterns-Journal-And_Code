using Creational_Pattern_Builder_BuilderParameter.Contracts;

namespace Creational_Pattern_Builder_BuilderParameter.Models;

public class MessagePublisher : IMessagePublisher
{
    public string Name { get; set; }

    private event Action<Message>? ReceiverEvents;

    public MessagePublisher(string name)
    {
        Name = name;
    }

    public void AddReceiver(Action<Message> receiverAction)
    {
        ReceiverEvents += receiverAction;
    }

    public void SendMessage(Message message)
    {
        if (ReceiverEvents is null)
        {
            return;
        }

        ReceiverEvents(message);
    }

    public override string ToString()
    {
        return $"Publisher {{{Name}}}";
    }
}