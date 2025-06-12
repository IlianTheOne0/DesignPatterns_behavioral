namespace ClassLibrary.BehavioralPatterns.Command.Implementation;

using ClassLibrary.BehavioralPatterns.Command.Interface;

public class WelcomeCommands : ICommand<string, string>
{
    public string Execute(string name) { return $"Hello, {name}!"; }
}

public class FarewellCommands : ICommand<string, string>
{
    public string Execute(string name) { return $"Bye, {name}!"; }
}