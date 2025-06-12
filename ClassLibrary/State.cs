namespace ClassLibrary.BehavioralPatterns.State.StateOfEntity;

public interface IState<TMethod>
{
    public void PowerOn(TMethod settings);
    public void ChangeSettings(TMethod settings);
    public void ShutDown();
    public void DisplayStatus();
}

public abstract class State<TMethod> : IState<TMethod>
{
    public abstract void PowerOn(TMethod settings);
    public abstract void ChangeSettings(TMethod settings);
    public abstract void ShutDown();
    public abstract void DisplayStatus();
}