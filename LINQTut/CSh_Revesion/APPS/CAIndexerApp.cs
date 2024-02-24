

namespace CSh_Revesion.APPS;

internal class CAIndexerApp
{
    public static void Run(string[] args)
    {
        Sentence s1 = new("The quick brown fox");

        Console.WriteLine(s1);
        Console.WriteLine(s1[..2]);

        Console.ReadKey();
    }
}

class Sentence
{
    string[] _words;

    public Sentence(string text)
    {
        _words = text.Split();
    }

    public string this[int index]
    {
        get => _words[index];
        set => _words[index] = value;
    }

    // Using indices and ranges with indexers
    public string this[Index index] => _words[index];

    public string this[Range range] => String.Join(' ', _words[range]);

    public override string ToString()
    {
        return String.Join(' ', _words);
    }


}