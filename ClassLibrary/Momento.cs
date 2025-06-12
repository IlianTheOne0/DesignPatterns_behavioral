namespace ClassLibrary.BehavioralPatterns.Momento.Momento;

using ClassLibrary.BehavioralPatterns.Momento.Origin;

public interface IMomento
{
    void SetState(List<object> args);
    List<object> GetState();
}
public class GameCharacterMemento : GameCharacter, IMomento
{
    public GameCharacterMemento() { }
    public GameCharacterMemento(string Name) : base(Name) { }
    public GameCharacterMemento (
        string Name, int Level, int Health, int MaxHealth, int Energy, int MaxEnergy,
        int Strength, int Agility, int Intelligence, float PositionX, float PositionY,
        bool IsAlive, int Experience
    ) : base (
        Name, Level, Health, MaxHealth, Energy, MaxEnergy, Strength, Agility, Intelligence, PositionX, PositionY, IsAlive, Experience
    ) { }

    public List<object> GetState() => new List<object> {
        Name, Level, Health, MaxHealth, Energy, MaxEnergy, Strength, Agility, Intelligence, PositionX, PositionY, IsAlive, Experience
    };

    public void SetState(List<object> args)
    {
        Name = (string)args[0];
        Level = (int)args[1];
        Health = (int)args[2];
        MaxHealth = (int)args[3];
        Energy = (int)args[4];
        MaxEnergy = (int)args[5];
        Strength = (int)args[6];
        Agility = (int)args[7];
        Intelligence = (int)args[8];
        PositionX = (float)args[9];
        PositionY = (float)args[10];
        IsAlive = (bool)args[11];
        Experience = (int)args[12];
    }

    public override string ToString() =>
        $"Character: {Name}, Level: {Level}, HP: {Health}/{MaxHealth}, Energy: {Energy}/{MaxEnergy}, " +
        $"Stats[STR: {Strength}, AGI: {Agility}, INT: {Intelligence}], " +
        $"Position: ({PositionX}, {PositionY}), Status: {(IsAlive ? "Alive" : "Dead")}, EXP: {Experience}";
}