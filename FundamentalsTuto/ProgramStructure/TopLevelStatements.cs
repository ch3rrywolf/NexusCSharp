/*
    Basic CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

   Tutorial: Top-level statements - programs without Main methods.
    1. Only one top-level file.
    2. No other entry points.
    3. using directives.
    4. Global namespace.
    5. Namespaces and type definitions.
    6. args.
    7. await.
    8. Exit code for the process.
    9. Implicit entry point method.
*/


/* ### 1. Only one top-level file. ###*/
// Top-level statements allow you to write executable code directly at the root of a file,
// eliminating the need for wrapping your code in a class or method.
// This means you can create programs without the ceremony of a Program class and a Main method.
// the compiler generates a Program class with an entry point method for the application.
// The name of the generated method isn't Main , it's an implementation detail that your code can't reference directly.
Console.WriteLine("Hello World!");
// An application must have only one entry point.
// A project can have only one file with top-level statements.
// Putting top-level statements in more than one file in a project results in the following compiler error:
//CS8802 Only one compilation unit can have top-level statements.
// A project can have any number of source code files that don't have top-level statements.


/* ### 2. No other entry points. ###*/
// You can write a Main method explicitly, but it can't function as an entry point.
// The compiler issues the following warning:
//CS7022 The entry point of the program is global code; ignoring 'Main()' entry point.
//In a project with top-level statements, you can't use the -main compiler option to select the entry point, even if the project has one or more Main methods.


/* ### 3. using directives. ###*/
// For the single file containing top-level statements using directives must come first in that file.
using System.Text;
StringBuilder builder = new();
builder.AppendLine("The following arguments are passed:");
foreach (var arg in args)
{
    builder.AppendLine($"Argument={arg}");
}
Console.WriteLine(builder.ToString());
return 0;


/* ### 4. Global namespace. ###*/
// Top-level statements are implicitly in the global namespace.


/* ### 5. Namespaces and type definitions. ###*/
// A file with top-level statements can also contain namespaces and type definitions,
// but they must come after the top-level statements.
MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();
public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("Hello World!");
    }
}
namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
        }
    }
}


/* ### 6. args. ###*/
// Top-level statements can reference the args variable to access any command-line arguments that were entered.
// The args variable is never null but its Length is zero if no command-line arguments were provided.
if (args.Length > 0)
{
    foreach (var arg in args)
    {
        Console.WriteLine($"Argument={arg}");
    }
}
else
{
    Console.WriteLine("No arguments");
}


/* ### 7. await. ###*/
// You can call an async method by using await.
Console.Write("Hello ");
await Task.Delay(5000);
Console.WriteLine("World!");


/* ### 8. Exit code for the process. ###*/
// To return an int value when the application ends,
// use the return statement as you would in a Main method that returns an int .
string? s = Console.ReadLine();
int returnValue = int.Parse(s ?? "-1");
return returnValue;


/* ### 9. Implicit entry point method. ###*/
// The compiler generates a method to serve as the program entry point for a project with top-level statements.
// The signature of the method depends on whether the top-level statements contain the await keyword or the return statement.
static async Task<int> Main(string[] args) //await and return 
static async Task Main(string[] args) //await
static int Main(string[] args) //return
static void Main(string[] args) //No await or return
// programs can be file based programs, where a single file contains the program.
// You run file based programs with the command dotnet run <file.cs> ,
// or using the
// #!/usr/local/share/dotnet/dotnet run directive as the first line (unix shells only).