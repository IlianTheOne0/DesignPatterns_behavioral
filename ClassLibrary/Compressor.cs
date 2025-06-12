namespace ClassLibrary.BehavioralPatterns.Strategy.Context;

using ClassLibrary.BehavioralPatterns.Strategy.Stategy;

public class Compressor
{
    private ICompressionStrategy _strategy;

    public Compressor(ICompressionStrategy strategy) => _strategy = strategy;

    public void SetStrategy(ICompressionStrategy strategy) => _strategy = strategy;
    public string Compress(string data) => _strategy.Compress(data);
}