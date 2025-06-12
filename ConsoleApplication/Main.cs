namespace ClassLibrary.BehavioralPatterns.Command;

using ClassLibrary.BehavioralPatterns.Command.Implementation;

public class Client
{
    public static void Main(string[] args)
    {
        WelcomeCommands welcomeCommand = new WelcomeCommands();
        FarewellCommands farewellCommand = new FarewellCommands();

        Console.WriteLine(welcomeCommand.Execute("World"));
        Console.WriteLine(farewellCommand.Execute("Tom"));
    }
}