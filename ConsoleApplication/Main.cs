namespace ClassLibrary.BehavioralPatterns.Momento;

using ClassLibrary.BehavioralPatterns.Momento.Story;
using ClassLibrary.BehavioralPatterns.Momento.Momento;
using ClassLibrary.BehavioralPatterns.Momento.Origin;

internal class Client
{
    static void Main(string[] args)
    {
        GameCharacter character = new GameCharacter("Hero", 1, 100, 100, 100, 100, 10, 10, 10, 0.0f, 0.0f, true, 0);

        Console.WriteLine(character.SaveState());
        Console.WriteLine();

        History history = new History();

        history.AddState(character.SaveState());
        Console.WriteLine();

        character.Level = 2;
        character.Health = 120;
        character.MaxHealth = 120;
        character.Energy = 110;
        character.MaxEnergy = 110;
        character.Strength = 12;
        character.Experience = 100;

        Console.WriteLine(character.SaveState());
        Console.WriteLine();

        history.AddState(character.SaveState());

        character.Health = 50;
        character.Energy = 40;
        character.PositionX = 10.5f;
        character.PositionY = 20.3f;

        Console.WriteLine(character.SaveState());
        Console.WriteLine();

        character.RestoreState((GameCharacterMemento)history.GetState());
        Console.WriteLine(character.SaveState());
        Console.WriteLine();

        character.RestoreState((GameCharacterMemento)history.GetState());
        Console.WriteLine(character.SaveState());
        Console.WriteLine();
    }
}