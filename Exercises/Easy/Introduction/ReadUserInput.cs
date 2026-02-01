/*
    Exercises CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

    Description: Read user input.
    - Write a C# program that asks the user What is your favorite animal?.
      Then stop program execution using the Console.Read statement.
      When the user presses Enter the program will respond Mine too! on the second line.
*/

using System;
public class ReadUserInput
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your favorite animal?");
        Console.ReadLine();
        Console.WriteLine("Mine too!");
    }
}