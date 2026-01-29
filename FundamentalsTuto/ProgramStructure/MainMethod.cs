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


/* ### 3. Async Main return values. ###*/
// An advantage of declaring Main as async is that the compiler always generates the correct code.
// When the application entry point returns a Task or Task<int>, the compiler generates a new entry point that calls the entry point method declared in the application code.
// Assuming that this entry point is called $GeneratedMain.
class Program
{
    static async Task<int> Main(string[] args)
    {
        return await AsyncConsoleWork();
    }
    private static async Task<int> AsyncConsoleWork()
    {
        return 0;
    }
}

static Task Main() //results in the compiler emitting the equivalent of private static void 
// $GeneratedMain() => Main().GetAwaiter().GetResult();.
static Task Main(string[]) //results in the compiler emitting the equivalent of private static void 
// $GeneratedMain(string[] args) => Main(args).GetAwaiter().GetResult();.
static Task<int> Main() //results in the compiler emitting the equivalent of private static int 
// $GeneratedMain() => Main().GetAwaiter().GetResult();.
static Task<int> Main(string[]) //results in the compiler emitting the equivalent of private static int 
// $GeneratedMain(string[] args) => Main(args).GetAwaiter().GetResult();.
//If the examples use the async modifier on the Main method, the compiler generates the same code.


// /* ### 4. Command-line arguments. ###*/
// // You can send arguments to the Main method by defining the method in one of the following ways.
static void Main(string[] args)	//No return value or await
static int Main(string[] args)	//Returns a value but doesn't use await
static async Task Main(string[] args)	//Uses await but doesn't return a value
static async Task<int> Main(string[] args)	//Return a value and uses await
// // If you don't use the arguments, you can omit args from the method declaration for slightly simpler code.
static void Main()	//No return value or await
static int Main()	//Returns a value but doesn't use await
static async Task Main()	//Uses await but doesn't return a value
static async Task<int> Main()	//Returns a value and uses await
// convert the string arguments to numeric types by using the Convert class or the Parse method.
// Parsing command-line arguments can be complex.
long num = Int64.Parse(args[0]); // statement converts the string to a long number by using the Parse method.
long num = long.Parse(args[0]); // poosible to use the C# type long, which aliases Int64.
long num = Convert.ToInt64(s); // use the Convert class method ToInt64 to do the same thing.

// command-line arguments in a console application.
// The application takes one argument at run time,
// converts the argument to an integer,
// and calculates the factorial of the number.
// If no arguments are supplied,
// the application issues a message that explains the correct usage of the program.
public class Functions
{
    public static long Factorial(int n)
    {
        // Test for invalid input.
        if ((n < 0) || (n > 20))
        {
            return -1;
        }
        // Calculate the factorial iteratively rather than recursively.
        long tempResult = 1;
        for (int i = 1; i <= n; i++)
        {
            tempResult *= i;
        }
        return tempResult;
    }
}
class MainClass
{
    static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter a numeric argument.");
            Console.WriteLine("Usage: Factorial <num>");
            return 1;
        }
        int num;
        bool test = int.TryParse(args[0], out num);
        if (!test)
        {
            Console.WriteLine("Please enter a numeric argument.");
            Console.WriteLine("Usage: Factorial <num>");
            return 1;
        }
        long result = Functions.Factorial(num);
        if (result == -1)
            Console.WriteLine("Input must be >= 0 and <= 20.");
        else
            Console.WriteLine($"The Factorial of {num} is {result}.");
        return 0;
    }
}

// rust@rust:~/Desktop/NexusCSharp/FundamentalsTuto/ProgramStructure$ dotnet run MainMethod.cs -- 3
// The Factorial of 3 is 6.
// When running an application in Visual Studio, specify command-line arguments in the
// Debug Page, Project Designer.