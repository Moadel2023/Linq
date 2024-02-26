

namespace CSh_Revesion.APPS;

public static class Extensions
{
    public static void Print<T>(this IEnumerable<T> source, string title)
    {
        Console.WriteLine($"");
        Console.WriteLine($"┌───────────────────────────────────────────────────────┐");
        Console.WriteLine($"|   {title.PadRight(52, ' ')}|");
        Console.WriteLine($"└───────────────────────────────────────────────────────┘");
        Console.WriteLine($"");

        foreach (var item in source)
        {
            if (typeof(T).IsValueType)
                Console.WriteLine($" {item} ");
            else
                Console.WriteLine(item);


        }
    }
}
