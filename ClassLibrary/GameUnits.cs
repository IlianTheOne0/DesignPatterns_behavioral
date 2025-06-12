namespace ClassLibrary.BehavioralPatterns.Mediator.GameUnits;

public interface IGameUnit
{
    string Name { get; }
    void ReactOn(object args);
}

public class GameUnit : IGameUnit
{
    public string Name { get; }
    
    public GameUnit(string Name) => this.Name = Name;

    public virtual void ReactOn(object args) => Console.WriteLine($"Game unit {this.Name} reacts on {args}.");
}

public class Soldier : GameUnit
{
    public Soldier(string Name) : base(Name) { }

    public void Shoot() => Console.WriteLine($"The soldier {this.Name} is shooting!");
    public override void ReactOn(object args) { base.ReactOn(args); Shoot(); }
}

public class Tank : GameUnit
{
    public Tank(string Name) : base(Name) { }

    public void Move() => Console.WriteLine($"The tank {this.Name} is moving!");
    public override void ReactOn(object args) { base.ReactOn(args); Move(); }
}

public class Aircraft : GameUnit
{
    public Aircraft(string Name) : base(Name) { }

    public void Bomb() => Console.WriteLine($"The aircraft {this.Name} is bombing the target!");
    public override void ReactOn(object args) { base.ReactOn(args); Bomb(); }
}