namespace ClassLibrary.BehavioralPatterns.Observer;

using ClassLibrary.BehavioralPatterns.Observer.Component;

public class CLient
{
    public static void Main()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber1 = new Subscriber("Subscriber 1");
        Subscriber subscriber2 = new Subscriber("Subscriber 2");

        publisher.Subscribe(subscriber1);
        publisher.Subscribe(subscriber2);

        publisher.NotifySubscribers(new EventData("First notification"));

        publisher.Unsubscribe(subscriber2);
        publisher.NotifySubscribers(new EventData("Second notification"));
    }
}