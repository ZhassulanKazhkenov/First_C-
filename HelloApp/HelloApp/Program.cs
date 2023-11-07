//Limitations of generalizations
/*
SendMessage(new Message("Hello World"));
SendMessage(new EmailMessage("Bye World"));

void SendMessage<T>(T message) where T : Message
{
    Console.WriteLine($"Отправляется сообщение: {message.Text}");
}
class Message
{
    public string Text { get; } // текст сообщения
    public Message(string text)
    {
        Text = text;
    }
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}
*/
//Limitations of generalizations in types

/*

Messenger<Message> telegram = new Messenger<Message>();
telegram.SendMessage(new Message("Hello World"));

Messenger<EmailMessage> outlook = new Messenger<EmailMessage>();
outlook.SendMessage(new EmailMessage("Bye World"));
class Messenger<T> where T : Message
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
}

class Message
{
    public string Text { get; } // текст сообщения
    public Message(string text)
    {
        Text = text;
    }
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}
*/
//Using multiple universal parameters

Messenger<Message, Person> telegram = new Messenger<Message, Person>();
Person tom = new Person("Tom");
Person bob = new Person("Bob");
Message hello = new Message("Hello, Bob!");
telegram.SendMessage(tom, bob, hello);

class Messenger<T, P>
    where T : Message
    where P : Person
{
    public void SendMessage(P sender, P receiver, T message)
    {
        Console.WriteLine($"Отправитель: {sender.Name}");
        Console.WriteLine($"Получатель: {receiver.Name}");
        Console.WriteLine($"Сообщение: {message.Text}");
    }
}
class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}

class Message
{
    public string Text { get; } // текст сообщения
    public Message(string text) => Text = text;
}