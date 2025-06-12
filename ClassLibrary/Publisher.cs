namespace ClassLibrary.BehavioralPatterns.Observer.Component;

public class Publisher
{
    private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

    public void Subscribe(ISubscriber subscriber)
    {
        if (!_subscribers.Contains(subscriber)) { _subscribers.Add(subscriber); }
    }

    public void Unsubscribe(ISubscriber subscriber) => _subscribers.Remove(subscriber);

    public void NotifySubscribers(EventData eventData)
    {
        foreach (var subscriber in _subscribers) { subscriber.Update(eventData); }
    }
}