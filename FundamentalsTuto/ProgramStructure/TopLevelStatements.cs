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
