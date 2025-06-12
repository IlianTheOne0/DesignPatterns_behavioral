namespace ClassLibrary.BehavioralPatterns.COR.Abstraction;

using ClassLibrary.BehavioralPatterns.COR.Interface;

public abstract class Handler : IHandler
{
    private IHandler? _nextHandler;

    public IHandler SetNext(IHandler handler) { _nextHandler = handler; return handler; }
    public virtual void HandleRequest(string request)
    {
        if (_nextHandler != null) { _nextHandler.HandleRequest(request); }
        else { Console.WriteLine($"No handler available for: {request}"); }
    }
}