/*
    Basic CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

   Tutorial: Main() and command-line arguments.
    1. Overview.
    2. Main() return values.
    3. Async Main return values.
    4. Command-line arguments.
*/

/* ### 1. Overview. ###*/
// The Main method is the entry point of a C# program.
// top-level statements can be used instead of defining a Main method.
class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(args.Length);
    }
}
// foreach loop to display the command-line arguments by using the args variable.
using System.Text;
StringBuilder builder = new();
builder.AppendLine("The following arguments are passed:");
foreach (var arg in args)
{
    builder.AppendLine($"Argument={arg}");
}
Console.WriteLine(builder.ToString());
return 0;
// By using async and Task or Task<int> return types, you simplify program code when console applications need to start and await asynchronous operations in Main.
static void Main() { }
static int Main() { }
static void Main(string[] args) { }
static int Main(string[] args) { }
static async Task Main() { }
static async Task<int> Main() { }
static async Task Main(string[] args) { }
static async Task<int> Main(string[] args) { }


/* ### 2. Main() return values. ###*/
// You can return an int from the Main method by defining the method in one of the following ways.
static int Main()	//No use of args or await
static int Main(string[] args)	//Uses args but not await
static async Task<int> Main()	//Uses await but not args
static async Task<int> Main(string[] args)	//Uses args and await
// If the return value from Main isn't used, returning void or Task allows for slightly simpler code.
static void Main()	//No use of args or await
static void Main(string[] args)	//Uses args but not await
static async Task Main()	//Uses await but not args
static async Task Main(string[] args)	//Uses args and await
class MainReturnValTest
{
    static int Main()
    {
        //...
        return 0;
    }
}
//test.ps1 powwerShell script to run the program and check the return value eq 0 or ne 0
//Execution succeeded
//Return value =  1
//Execution Failed
//Return value =  1