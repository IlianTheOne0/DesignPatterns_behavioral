namespace ClassLibrary.BehavioralPatterns.Mediator;

using ClassLibrary.BehavioralPatterns.Mediator.Mediator;
using ClassLibrary.BehavioralPatterns.Mediator.GameUnits;

internal class Client
{
    static void Main(string[] args)
    {
        Base mediator = new Base();

        mediator.AddComponent("soldier", new Soldier("John"));
        mediator.AddComponent("tank", new Tank("T-90"));
        mediator.AddComponent("aircraft", new Aircraft("F-22"));

        string sender = "soldier";
        mediator.Notify(sender);

        mediator.RemoveComponent("tank");

        sender = "tank";
        mediator.Notify(sender);

        sender = "aircraft";
        mediator.Notify(sender);

        Console.ReadLine();
    }
}