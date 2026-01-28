/*
    Basic CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

   Tutorial: C# program structure.
    1. General Structure of a C# Program.
    2. Building and running C# programs.
    3. Expressions and statements.
*/


/* ### 1. General Structure of a C# Program. ###*/
// The preceding example uses top-level statements for the program's entry point.
// Only one file can have top-level statements.
using System;
Console.WriteLine("Hello world!");
namespace YourNamespace
{
class YourClass
{
}
struct YourStruct
{
}
interface IYourInterface
{
}
delegate int YourDelegate();
enum YourEnum
{
}
namespace YourNestedNamespace
{
struct YourStruct
{
}
}
}

// A skeleton of a C# program
// In that case the program starts in the opening brace of Main method.
using System;
namespace YourNamespace
{
class YourClass
{
}
struct YourStruct
{
}
interface IYourInterface
{
}
delegate int YourDelegate();
enum YourEnum
{
}
namespace YourNestedNamespace
{
struct YourStruct
{
}
}
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Hello world!");
}
}
}

/* ### 2. Building and running C# programs. ###*/
#!/usr/local/share/dotnet/dotnet run // the #! sequence for Unix shells
Console.WriteLine("Hello, World!");


/* ### 3. Expressions and statements. ###*/
// Expression is combination of value, variables, operators and method calls that evaluate to a single value.
42 //Literal value
x + y //arithmetic operation
Math.Max(a, b)
condition ? trueValue : falseValue // conditional expression
new Person("John") // object creation
// Statement is a complete instruction that performs an action
int x = 42; //declaration statement
Console.WriteLine("Hello"); //expression statement - wraps a method call expression
if (condition) { /*code*/}
return result; //return statement
//The key distinction: expressions evaluate to values, while statements perform actions.
//Some constructs, like method calls, can be both.
//For example: Math.Max(a, b) is an expression when used in int result = Math.Max(a, b);
//But becomes an expression statement when written alone as Math.Max(a, b);