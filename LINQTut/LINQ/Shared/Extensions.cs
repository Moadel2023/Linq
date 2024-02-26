

namespace LINQ.Shared;

public static class Extensions
{

   
   
    public static void Print<T>(this IEnumerable<T> source, string title)
    {
        if (source is null) return;

        Console.WriteLine($"");
        Console.WriteLine($"┌───────────────────────────────────────────────────────┐");
        Console.WriteLine($"|   {title.PadRight(52, ' ')}|");
        Console.WriteLine($"└───────────────────────────────────────────────────────┘");
        Console.WriteLine($"");

        foreach (var item in source)
        {
            if (typeof(T).IsValueType)
                Console.Write($" {item} ");
            else
                Console.WriteLine(item);
        }
    }
}
