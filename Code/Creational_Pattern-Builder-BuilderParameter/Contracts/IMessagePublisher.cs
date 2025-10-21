using Creational_Pattern_Builder_BuilderParameter.Models;

namespace Creational_Pattern_Builder_BuilderParameter.Contracts;

public interface IMessagePublisher
{
    void SendMessage(Message message);
    void AddReceiver(Action<Message> receiverAction);
}