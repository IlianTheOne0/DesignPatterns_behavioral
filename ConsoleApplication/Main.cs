namespace ClassLibrary.BehavioralPatterns.Strategy;

using ClassLibrary.BehavioralPatterns.Strategy.Context;
using ClassLibrary.BehavioralPatterns.Strategy.Stategy;

internal class Client
{
    public static void Main(string[] args)
    {
        var data = "aaabbbbcc";

        var rle = new RLECompression();
        var none = new NoCompression();

        var compressor = new Compressor(rle);
        Console.WriteLine("RLE: " + compressor.Compress(data));  // Output: a3b4c2

        compressor.SetStrategy(none);
        Console.WriteLine("None: " + compressor.Compress(data)); // Output: aaabbbbcc
    }
}
