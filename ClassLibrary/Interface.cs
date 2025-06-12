namespace ClassLibrary.BehavioralPatterns.COR.Interface;

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    void HandleRequest(string request);
}