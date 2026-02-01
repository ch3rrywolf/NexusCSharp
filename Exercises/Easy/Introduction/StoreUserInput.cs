/*
    Exercises CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

    Description: Store user input.
    - Create a program in C# that asks the user in the first line What is your name? and save the name in the variable x.
      The program must respond on the second line with Nice to meet you, x.
*/

using System;
public class StoreUserInput
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string x = Console.ReadLine();
        Console.WriteLine($"Nice to meet you, {x}");
    }
}

// Note: to correct this warnning "warning CS8600: Converting null literal or possible null value to non-nullable type."
// so will be add this "?" in string type ==> string? x = Console.ReadLine();