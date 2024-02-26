
using LINQ.Shared;
using System.Diagnostics.Tracing;

namespace LINQ.APPS;

internal class Tut04App
{
    /* Projection Operation :
        1- Select 
        2- SelectMany
        3- Zip
     */
    public static void Run(string[] args)
    {

        //RunExpmple01();
        //RunExpmple02();


        //RunExpmple03();
        //RunExpmple04();


        //RunExpmple05();
        RunExpmple06();


        Console.ReadKey();
    }

    #region SELECT
    public static void RunExpmple01()
    {
        List<string> words = new() { "i", "love", "c#", "programming" };

        var result01 = words.Select(w => w.ToUpper());

        var result02 = from w in words
                       select w.ToUpper();

        result01.Print("Upper Words Using Extension");
        result02.Print("Upper Words Using Query");



        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Query Syntax
        var result03 = from n in numbers
                       select n * n;

        result03.Print("Squre numbers Using Query Syntax");


    }

    public static void RunExpmple02()
    {
        var employees = Repository.LoadEmployees();

        var result01 = employees.Select(emp => new EmployeeDto
        {
            Name = $"{emp.FirstName} {emp.LastName}",
            TotalSkills = emp.Skills.Count()
        }
        );

        result01.Print("Employees Dto");
    }
    #endregion


    #region SELECT MANY

    public static void RunExpmple03()
    {
        List<string> sentences = new()
        {
            "I love Asp.net core",
            "I love also sql server",
            "in general I love programming"
        };

        // Using SelectMany Extension Methods
        var words01 = sentences.SelectMany(w => w.Split());

        // Using Qyery Syntax
        var words02 = from s in sentences
                      from w in s.Split()
                      select w;


        words02.Print("Words of Sentences");
    }
    public static void RunExpmple04()
    {
        
        
        
        
        var employees = Repository.LoadEmployees();



        // Using Extension Mthod
        var skills01 = employees.SelectMany(emp => emp.Skills).Distinct();
        skills01.Print("Skills of Employees Using SelectMany Extension Method");

        // Using Query Syntax
        var skills = (from emp in employees
                     from sk in emp.Skills
                     select sk).Distinct();

        //skills.Print("Skills of Employees Using Query Syntax");

        }


    #endregion


    #region Zip
        
    public static void RunExpmple05()
    {
        string[] colors = { "Red", "Blue", "Green" };
        string[] hex = { "0x07778", "0x04757", "0x02138" };

        var output = colors.Zip(hex, (c, h) => $"{c}\t: ({h})");

        output.Print("Colors _ Hex");
    }

    public static void RunExpmple06()
    {
        var employees = Repository.LoadEmployees().ToArray();

        var firsThreeEmployees = employees[..3];
        var lastThreeEmployees = employees[^3..];



        // Using Zip Extension Method
        var teams01 = firsThreeEmployees.Zip(lastThreeEmployees,
                (f, l) => $"{f.FullName}\t with\t {l.FullName}");

        // Using Query Syntax
        var teams02 = from team in firsThreeEmployees.Zip(lastThreeEmployees)
                      select  $"{team.First.FullName}\t with\t {team.First.FullName}";



        teams02.Print("Teams");
    }

        #endregion
    
}
