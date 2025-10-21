using Creational_Pattern_Builder_BuilderParameter.Models;
using Creational_Pattern_Builder_BuilderParameter.Services;

var receiver1 = new MessageReceiver("Receiver1");
var receiver2 = new MessageReceiver("Receiver2");

var publisher = new MessagePublisher("Publisher");
receiver1.SubscribeTo(publisher);
receiver2.SubscribeTo(publisher);

var emailService = new MessageService();
emailService.SendMessage(publisher, message => message
    .WithSubject("Print something")
    .WithText("Hello World"));