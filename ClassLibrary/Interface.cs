namespace ClassLibrary.BehavioralPatterns.Iterator.Interface;

public interface IIterator<TMethod>
{
    bool SetNext();
    TMethod Handle();
}

public interface IAggregate<TMethod>
{
    IIterator<TMethod> CreateIterator();
}