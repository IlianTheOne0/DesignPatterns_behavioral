namespace ClassLibrary.BehavioralPatterns.Command.Interface;

public interface ICommand<TReturn, TArgs>
{
    TReturn Execute(TArgs source);
}