namespace ClassLibrary.BehavioralPatterns.Momento.Story;

using ClassLibrary.BehavioralPatterns.Momento.Momento;

public class History
{
    private Stack<IMomento> _stack;
    public History() { _stack = new Stack<IMomento>(); }
    public void AddState(IMomento momento) { _stack.Push(momento); Console.WriteLine($"Add new snapshot: {momento}..."); }
    public IMomento GetState() { IMomento momento = _stack.Pop(); Console.WriteLine($"Get snapshot: {momento}..."); return momento; }
}