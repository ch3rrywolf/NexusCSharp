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