/*
    Basic CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

   Tutorial: C# if statements and loops conditional logic.
    1. Use if statements.
    2. Make if and else work together.
    3. Use loops to repeat operations.
    4. Work with the for loop.
    5. Created nested loops.
    6. Combine branches and loops.
*/


/* ### 1.Use if statements ###*/
// The if statement checks the value of a bool.
// When the value is true, the statement following the if executes. 
// this process of checking conditions and executing statements based on those conditions is powerful.
int a = 5;
int b = 6;
b = 3;
if (a + b > 10) // nothing is printed. condition is false
    Console.WriteLine("The answer is greater than 10.");


/* ### 2.Make if and else work together ###*/
int a = 5;
int b = 3;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10.");
else // the statement following the else keyword executes only when the condition being tested is false.
    Console.WriteLine("The answer is not greater than 10.");
int a = 5;
int b = 3;
if (a + b > 10)
{
    Console.WriteLine("The answer is greater than 10.");
}
else 
{
    Console.WriteLine("The answer is not greater than 10.");
}// when you want more than one statement to be part of the block that executes conditionally. {}

int a = 5;
int b = 5;
int c = -3;
if ((a + b + c > 10) && (a == b)) // "==" symbol tests for equality. "&&" represents "and".
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}
int a = 5;
int b = 5;
int c = -3;
if ((a + b + c > 10) || (a == b)) // "||" or.
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

ExploreIf();
void ExploreIf()
{
int a = 5;
int b = 3;
if (a + b > 10)
{
    Console.WriteLine("The answer is greater than 10");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}
int c = 4;
if ((a + b + c > 10) && (a > b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is greater than the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not greater than the second");
}
if ((a + b + c > 10) || (a > b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is greater than the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not greater than the second");
}
}



/* ### 3.Use loops to repeat operations ###*/
int counter = 0;
while (counter < 10) // the while loop tests the condition before executing the code following the while.
{
    Console.WriteLine($"Hello World! the counter is {counter}");
    counter++; // increment the counter by 1 "exmpl" : counter = counter + 1;
}
int counter = 0;
do
{
    Console.WriteLine($"Hello World! the counter is {counter}");
    counter++;
} while (counter < 10); // the do...while loop executes the code once before testing the condition at the end of the loop.


/* ### 4.Work with the for loop ###*/
for (int counter = 0; counter < 10; counter++) // the for loop combines the initialization, condition, and increment in one line.
{
    Console.WriteLine($"Hello World! the counter is {counter}");
}


/* ### 5.Created nested loops ###*/
for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"the row is {row}");
}
for (char column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"the column is {column}");
}
for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"the cell is {row}, {column}");
    }
}
ExploreLoops();
void ExploreLoops()
{
    for (int row = 11; row > 1; row--)
{
    for (char column = 'k'; column > 'a'; column--)
    {
        Console.WriteLine($"the cell is {row}, {column}"); // the outer loop increments once for each full run of the inner loop.
    }
}
}