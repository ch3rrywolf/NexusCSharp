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


/*  ### 2.Explore order of operations ###*/
// the rules you learned in mathematics
OrderPrecedence();

void OrderPrecedence()
{ 
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c; // the multiplication is performed before the addition
    Console.WriteLine(d);
    d = (a + b) * c; // force a different order of operation by adding parentheses
    Console.WriteLine(d);
    d = (a + b) - 6 * c + (12 * 4) / 3 + 12; // combining many different operations
    Console.WriteLine(d);
    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g; // Integer dividion always produces an integer result
    Console.WriteLine(h);
}


/*  ### 3.Explore integer precision and limits ###*/
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c; // the remainder by using the remainder operator "%" caracter
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");
int max = int.MaxValue; // maximum limits
int min = int.MinValue; // minimum limits
Console.WriteLine($"The range of integers is {min} to {max}");
int what = max + 3; // overflow or underflow
Console.WriteLine($"An example of overflow: {what}");
Console.WriteLine($"{max - what}"); // ?? i see logic here bro ;)


/*  ### 4.Work with the double type ###*/
// Single precision numbers are declared by using the float keyword
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c; // the decimal portion of the quotient
Console.WriteLine(d);
double aa = 19;
double bb = 23;
double cc = 8;
double dd = (aa + bb) / cc;
Console.WriteLine(dd);
double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}"); //The number to the right is the exponent, as a power of 10
double third = 1.0 / 3.0; // 0.33 is 33/100 That value is closer to 1/3, but still not exact
Console.WriteLine(third);
//Challenge: calculations with large numbers, small numbers, multiplication, and division by using the double type, Name that new method WorkWithDoubles.
WorkWithDoubles();

void WorkWithDoubles()
{
    double z = 15E+50;
    double x = 20.15;
    double y = z * x;
    double yy = z / x;
    Console.WriteLine($"multiplication: {y}");
    Console.WriteLine($"division: {yy}");
}