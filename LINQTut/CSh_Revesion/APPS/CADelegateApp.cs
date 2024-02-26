

using System.Runtime.CompilerServices;

namespace CSh_Revesion.APPS;

internal class CADelegateApp
{

    #region Delegate
    /*
     * A delegate is an object that knows how to call a method
     */
    #endregion

    
    public delegate void act<T>(T act);
    public static void Run (string[] args)
    {
        #region MyRegion
        //act<string> t_1 = (x) => Console.WriteLine($"{x}");

        //act<string> t_2 = new act<string>((x) => Console.WriteLine($"{x}"));

        //act<string> t_3 = new((x) => Console.WriteLine($"{x}"));

        //// void Action <paramter> _name
        //Action<string, int> t1 = (x, y) => Console.WriteLine($"{x} {y}");

        //t1("The quick brown fox", 7);
        //t_1.Invoke("The quick brown fox"); 
        #endregion


        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        var q1 = Util.TransformAllUsingInterfce(numbers, new Square());
        
        var q2 = numbers.TransformAllUsingInterfce(new Square());

        var q3 = numbers.TransformAllUsingDelegate(x => x * x);

        var q4 = numbers.Select(x => x*x*x);

        q1.Print("q1_Squre numbers Using Enumerable Method");
        q2.Print("q2_Squre numbers Using Extension Method");

        q3.Print("q3_Squre numbers Using Extension Method And Delegate");

        q4.Print("Cube numbers Using LINQ");

        Console.ReadKey();
    }

  
}
/*
 * A delegate design might be a better choice than an interface design if one or more of these
    conditions are true:
        - The interface defines only a single method.
        - Multicast capability is needed.
        - The subscriber needs to implement the interface multiple times
 */


interface ITransformer
{
    public int Tranform(int x);
}

static class Util
{
    public static IEnumerable<int> TransformAllUsingInterfce(this IEnumerable<int> source, ITransformer t)
    {
        foreach (var item in source)
        {
            yield return t.Tranform(item);
        }
    }
    public static IEnumerable<int> TransformAllUsingDelegate(this IEnumerable<int> source, Func<int,int>t)
    {
        foreach (var item in source)
        {
            yield return t.Invoke(item);
        }
    }
}
class Square : ITransformer
{
    public int Tranform(int x)
    {
        return x * x;
    }
}
class Cube : ITransformer
{
    public int Tranform(int x)
    {
        return x * x * x;
    }
}