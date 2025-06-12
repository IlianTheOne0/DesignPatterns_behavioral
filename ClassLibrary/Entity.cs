namespace ClassLibrary.BehavioralPatterns.State.Entity;

using ClassLibrary.BehavioralPatterns.State.StateOfEntity;

public class AirplaneModeState<TMethod> : State<TMethod>
{
    protected TMethod _settings;

    public override void PowerOn(TMethod settings) { _settings = settings; Console.WriteLine($"Phone powered on in Airplane Mode with settings: {settings}"); }
    public override void ChangeSettings(TMethod settings) => Console.WriteLine("Cannot change network settings while in Airplane Mode!");
    public override void ShutDown() => Console.WriteLine("Phone is shutting down from Airplane Mode.");
    public override void DisplayStatus() => Console.WriteLine($"Phone is in Airplane Mode with settings: {_settings}");
}

public class NormalModeState<TMethod> : State<TMethod>
{
    protected TMethod _settings;

    public override void PowerOn(TMethod settings) { _settings = settings; Console.WriteLine($"Phone powered on in Normal Mode with settings: {settings}"); }
    public override void ChangeSettings(TMethod settings) { _settings = settings; Console.WriteLine($"Phone settings updated to: {settings}"); }
    public override void ShutDown() => Console.WriteLine("Phone is shutting down from Normal Mode.");
    public override void DisplayStatus() => Console.WriteLine($"Phone is in Normal Mode with settings: {_settings}");
}

public class MobilePhone<TMethod>
{
    private State<TMethod> _state;

    public MobilePhone(State<TMethod> initialState) => _state = initialState;

    public void SetState(State<TMethod> state) { _state = state; Console.WriteLine("Phone state changed."); }
    public void PowerOn(TMethod settings) => _state.PowerOn(settings);
    public void ChangeSettings(TMethod settings) => _state.ChangeSettings(settings);
    public void ShutDown() => _state.ShutDown();
    public void DisplayStatus() => _state.DisplayStatus();
}