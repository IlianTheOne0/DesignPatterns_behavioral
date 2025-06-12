namespace ClassLibrary.BehavioralPatterns.State;

using ClassLibrary.BehavioralPatterns.State.Entity;

internal class Client
{
    static void Main(string[] args)
    {
        MobilePhone<string> phone = new MobilePhone<string>(new NormalModeState<string>());

        phone.PowerOn("Default settings");
        phone.DisplayStatus();
        phone.ChangeSettings("Bluetooth enabled");

        phone.SetState(new AirplaneModeState<string>());
        phone.DisplayStatus();
        phone.ChangeSettings("Try to enable WiFi");

        phone.SetState(new NormalModeState<string>());
        phone.DisplayStatus();
        phone.ChangeSettings("WiFi enabled");

        phone.ShutDown();
    }
}