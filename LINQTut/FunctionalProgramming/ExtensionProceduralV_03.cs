public static class ExtensionProceduralV_03
{
    public static IEnumerable<Employee> Filter (this IEnumerable<Employee> source, Func<Employee, bool> prediacte)
    {
        foreach (var employee in source)
        {
            if (prediacte(employee))
                yield return employee;
        }
    }

    public static void Print<T>(this IEnumerable<T>source, string title)
    {
        if (source is null) return;

        Console.WriteLine($"");
        Console.WriteLine($"┌───────────────────────────────────────────────────────┐");
        Console.WriteLine($"|   {title.PadRight(52,' ')}|");
        Console.WriteLine($"└───────────────────────────────────────────────────────┘");
        Console.WriteLine($"");
        
        foreach (var item in source)
        {
            Console.WriteLine(item);
        }
    }
}