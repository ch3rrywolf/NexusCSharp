/*
    Exercises CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

    Description: Celsius to Kelvin and Fahrenheit.
    - The Celsius scale is centigrade, 100 divisions separate the freezing point from the boiling point of water.
      On the Fahrenheit scale of Anglo-Saxons, these two points are 180 degrees apart.
      The Kelvin scale is an absolute scale used in science.
    
    - Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit.
      Request the user the number of degrees celsius to convert them using the following conversion tables:
      kelvin = celsius + 273
      fahrenheit = celsius x 18 / 10 + 32

    - Example: celsius = 33
      kelvin= 306
      fahrenheit= 91
*/

using System;

public class CelsiusToKelvinAndFahrenheit
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter the number of degrees celsius");
    int celsius = Convert.ToInt32(Console.ReadLine());

    int kelvin = celsius + 273;
    int fahrenheit = celsius * 18 / 10 + 32;

    Console.WriteLine($"kelvin = {kelvin}\nfahrenheit = {fahrenheit}");
  }
}