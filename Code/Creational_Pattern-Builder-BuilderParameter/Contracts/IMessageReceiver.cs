using Creational_Pattern_Builder_BuilderParameter.Models;

namespace Creational_Pattern_Builder_BuilderParameter.Contracts;

public interface IMessageReceiver
{
    void SubscribeTo(IMessagePublisher publisher);
}