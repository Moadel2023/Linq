

using LINQ.Shared;

namespace LINQ.APPS;

internal class Tut03App
{
    #region LINQ Statement
    /*
     * Write LINQ Statemnt :
     * 1- Extension
     * 2- Enumerable Method
     * 3- Query
     */
    #endregion
    public static void Run(string[] args)
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 10 };



        // Extension 
        var evenNumbersUsingExtensionWhereMethod = numbers.Where(x => x % 2 == 0);

        // Enumerable Method
        var evenNumbersUsingEnumerableWhereMetho = Enumerable.Where(numbers, x => x % 2 == 0);

        // Query
        // Select n From numbers Where n%2 == 0
        var envenNumbersUingQuerySyntax =
            from n in numbers
            where n % 2 == 0
            select n;

        numbers.Add(12);
        numbers.Add(14);
        numbers.Remove(6);


        evenNumbersUsingExtensionWhereMethod.Print("even Numbers Using Extension Where Method");
        evenNumbersUsingEnumerableWhereMetho.Print("even Numbers Using Enumerable Where Metho");
        envenNumbersUingQuerySyntax.Print("enven Numbers Uing Query Syntax");


        Console.ReadKey();
    }
}
