namespace Creational_Pattern_Builder_BuilderParameter.Contracts;

public interface IMessageService
{
    void SendMessage(IMessagePublisher publisher, Action<IMessageBuilder> builder);
}