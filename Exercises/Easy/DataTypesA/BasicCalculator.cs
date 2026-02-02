/*
    Exercises CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

    Description: Basic calculator.
    - Write a program in C# that calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.
    - In addition you should also calculate the rest of the division on the last line.
*/

// solution 1
using System;

public class BasicCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number1:");
        int Number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number2:");
        int Number2 = Convert.ToInt32(Console.ReadLine());

        int adding = Number1 + Number2;
        int subtracting = Number1 - Number2;
        int multiplying = Number1 * Number2;
        float dividing = Number1 / Number2;
        int rest = Number1 % Number2;

        Console.WriteLine($"adding = {adding}");
        Console.WriteLine($"subtracting = {subtracting}");
        Console.WriteLine($"multiplying = {multiplying}");
        Console.WriteLine($"dividing = {dividing}");
        Console.WriteLine($"rest of the division = {rest}");
    }
}

// solution 2
using System;

public class BasicCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number1:");
        int Number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number2:");
        int Number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"adding = {Number1 + Number2}");
        Console.WriteLine($"subtracting = {Number1 - Number2}");
        Console.WriteLine($"multiplying = {Number1 * Number2}");
        Console.WriteLine($"dividing = {Number1 / Number2}");
        Console.WriteLine($"rest of the division = {Number1 % Number2}");
    }
}