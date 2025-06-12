namespace ClassLibrary.BehavioralPatterns.Observer.Component;

public class EventData
{
    public string Message { get; }

    public EventData(string message) => Message = message;
}