namespace ClassLibrary.BehavioralPatterns.Strategy.Stategy;

using System.Text;

public interface ICompressionStrategy
{
    string Compress(string data);
}

public class RLECompression : ICompressionStrategy
{
    public string Compress(string data)
    {
        if (string.IsNullOrEmpty(data)) { return string.Empty; }

        StringBuilder result = new StringBuilder();
        char last = data[0];
        int count = 1;

        for (int i = 1; i < data.Length; i++)
        {
            if (data[i] == last) { count++; }
            else { result.Append(last); result.Append(count); last = data[i]; count = 1; }
        }

        result.Append(last);
        result.Append(count);
        return result.ToString();
    }
}

public class NoCompression : ICompressionStrategy
{
    public string Compress(string data) => data;
}