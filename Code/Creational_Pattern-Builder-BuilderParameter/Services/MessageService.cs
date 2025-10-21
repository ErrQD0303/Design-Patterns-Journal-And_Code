using Creational_Pattern_Builder_BuilderParameter.Contracts;
using Creational_Pattern_Builder_BuilderParameter.Models;

namespace Creational_Pattern_Builder_BuilderParameter.Services;

public class MessageService : IMessageService
{
    public MessageService()
    {
    }

    public class MessageBuilder : IMessageBuilder
    {
        // Singleton
        private Message Message { get; }

        public MessageBuilder(Message message)
        {
            Message = message;
        }

        public IMessageBuilder WithSubject(string subject)
        {
            Message.Subject = subject;
            return this;
        }

        public IMessageBuilder WithText(string text)
        {
            Message.Text = text;
            return this;
        }
    }

    private void SendMessageInternal(IMessagePublisher publisher, Message message)
    {
        publisher.SendMessage(message);
    }

    public void SendMessage(IMessagePublisher publisher, Action<IMessageBuilder> builder)
    {
        var message = new Message()
        {
            From = publisher,
        };
        builder(new MessageBuilder(message));
        SendMessageInternal(publisher, message);
    }
}