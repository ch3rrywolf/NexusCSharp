/*
    Exercises CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

    Description: Calculate dimensions of sphere.
    - Create a program in C# for calculate the surface and volume of a sphere, given its radius.
      surface = 4 * pi * radius squared
      volume = 4 / 3 * pi * radius cubed
      
    - Example:
        Input:
          radius = 60
        Output:
          surface = 45238,93
          volume = 678584,1
*/ 

using System;

public class CalculateDimensionsOfSphere
{
  public static void Main(string[] args)
  {
    Console.WriteLine("given its radius");
    float radius = Convert.ToSingle(Console.ReadLine());
    float pi = 3.14159f;
    float surface = 4 * pi * (radius * radius);
    float volume = 4 / 3 * pi * (radius * radius * radius);
    Console.WriteLine($"surface = {surface}");
    Console.WriteLine($"volume = {volume}");
  }
}