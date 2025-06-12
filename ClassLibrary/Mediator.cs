namespace ClassLibrary.BehavioralPatterns.Mediator.Mediator;

using ClassLibrary.BehavioralPatterns.Mediator.GameUnits;

public interface IBase
{
    void Notify(object sender);
}

public class Base : IBase
{
    private Dictionary<string, GameUnit> GameUnits { get; set; }

    public Base() => GameUnits = new Dictionary<string, GameUnit>();

    public void AddComponent(string key, GameUnit component) => GameUnits.Add(key, component);
    public void RemoveComponent(string key) => GameUnits.Remove(key);
    public void Notify(object sender)
    {
        string key = sender.ToString()!;
        
        try { GameUnits[key].ReactOn(sender); }
        catch (KeyNotFoundException e) { Console.WriteLine(e.Message); }
    }
}