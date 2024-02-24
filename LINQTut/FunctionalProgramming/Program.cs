using System;

namespace FunctionalProgramming;

internal class Program
{
    static void Main(string[] args)
    {
        var list = Repository.LoadEmployees();
        list.Print("List of Employess");

        //RunExtensionProcedural_03();

        Console.ReadKey();
    }
    private static void RunExtensionProcedural_01()
    {
        var q1 = ExtensionProceduralV_01.GetEmployeesWithFirstNameStartWtith("ma");
        ExtensionProceduralV_01.Print(q1, "Employees with first name starts with 'ma'");
    }

    private static void RunExtensionProcedural_02()
    {
        var employees = Repository.LoadEmployees();
        var q1 = ExtensionProceduralV_02.Filter(employees, e => e.FirstName.ToLowerInvariant().StartsWith("ma"));
        ExtensionProceduralV_02.Print(q1, "Employees with first name starts with 'ma'");
    }
    private static void RunExtensionProcedural_03()
    {
        var list = Repository.LoadEmployees();
        var q1 = list.Filter(e => e.FirstName.ToLowerInvariant().StartsWith("ma") );
        q1.Print("Employees with first name starts with 'ma'");
    }
}

