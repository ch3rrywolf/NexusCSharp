/*
    Basic CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

   Tutorial: How to use integer and floating point numbers in C#.
    1. Explore integer math.
    2. Explore order of operations.
    3. Explore integer precision and limits.
    4. Work with the double type.
    5. Work with decimal types.
*/


/*  ### 1.Explore integer math ###*/
// separate method
WorkWithIntegers();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b; // addition
    Console.WriteLine(c);
    c = a - b; // subtraction
    Console.WriteLine(c);
    c = a * b; // multiplication
    Console.WriteLine(c);
    c = a / b; // division
    Console.WriteLine(c);
    c = a + b - 12 * 17; // mixing variables and constant numbers
    Console.WriteLine(c);
}