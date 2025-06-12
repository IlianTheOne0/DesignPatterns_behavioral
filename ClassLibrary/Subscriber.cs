namespace ClassLibrary.BehavioralPatterns.Observer.Component;

public interface ISubscriber
{
    void Update(EventData eventData);
}

public class Subscriber : ISubscriber
{
    private readonly string _name;

    public Subscriber(string name) => _name = name;

    public void Update(EventData eventData) => Console.WriteLine($"{_name} received event: {eventData.Message}");
}