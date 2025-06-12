using ClassLibrary.BehavioralPatterns.Momento.Momento;

namespace ClassLibrary.BehavioralPatterns.Momento.Origin;

public class GameCharacter
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; } = 1;

    public int Health { get; set; } = 100;
    public int MaxHealth { get; set; } = 100;
    public int Energy { get; set; } = 100;
    public int MaxEnergy { get; set; } = 100;

    public int Strength { get; set; } = 10;
    public int Agility { get; set; } = 10;
    public int Intelligence { get; set; } = 10;

    public float PositionX { get; set; }
    public float PositionY { get; set; }

    public bool IsAlive { get; set; } = true;
    public int Experience { get; set; } = 0;
    
    public GameCharacter() { }
    public GameCharacter(string Name) { this.Name = Name; }
    public GameCharacter (
        string Name, int Level, int Health, int MaxHealth, int Energy, int MaxEnergy,
        int Strength, int Agility, int Intelligence, float PositionX, float PositionY,
        bool IsAlive, int Experience
    )
    {
        this.Name = Name;
        this.Level = Level;
        this.Health = Health;
        this.MaxHealth = MaxHealth;
        this.Energy = Energy;
        this.MaxEnergy = MaxEnergy;
        this.Strength = Strength;
        this.Agility = Agility;
        this.Intelligence = Intelligence;
        this.PositionX = PositionX;
        this.PositionY = PositionY;
        this.IsAlive = IsAlive;
        this.Experience = Experience;
    }

    public GameCharacterMemento SaveState() => new GameCharacterMemento (
        Name, Level, Health, MaxHealth, Energy, MaxEnergy, Strength, Agility, Intelligence, PositionX, PositionY, IsAlive, Experience
    );

    public void RestoreState(GameCharacterMemento memento)
    {
        var args = memento.GetState();
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
}