/*
    Exercises CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

    Description: Reverse chars.
    - Write a program to ask the user for three letters and display them in reverse order.

    - Example:
        Input:
          a
          b
          c
        Output:
            c, b ,a
*/

using System;

public class ReverseChars
{
    public static void Main(string[] args)
    {
        char a = Convert.ToChar(Console.ReadLine());
        char b = Convert.ToChar(Console.ReadLine());
        char c = Convert.ToChar(Console.ReadLine());

        Console.WriteLine($"{c}, {b}, {a}");
    }
}

// Note: warning CS8604: Possible null reference argument for parameter 'value' in 'char Convert.ToChar(string value)'
// Convert.ToChar(Console.ReadLine()!)
// or
// Console.ReadKey().KeyChar
// or
// char.Parse(Console.ReadLine() ?? "")