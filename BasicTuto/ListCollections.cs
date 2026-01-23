/*
    Basic CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

   Tutorial: Learn to manage data collections using List<T> in C#.
    1. A basic list example.
    2. Modify list contents.
    3. Search and sort lists.
    4. Lists of other types.
    5. Challenge.
*/


/* ### 1.A basic list example ###*/
// created a list of strings
// added three names to that list
// and printed the names in all caps
List<string> names = ["<name>", "Ana", "Felipe"];
foreach (var name in names)
{
    Console.WriteLine($"Hello {name}!");
}


/* ### 2.Modify list contents ###*/
List<string> names = ["<name>", "Ana", "Felipe"];
//Console.WriteLine();
names.Add("Maria"); // added a name
names.Add("Bill");
names.Remove("Ana"); // removed a name
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToLower()}!"); // printed all names resulting list
    Console.WriteLine($"My name is {names[0]}"); // accessed first list item
    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list."); // accessed specific list items
    Console.WriteLine($"The list has {names.Count} people in it."); // printed list count
}


/* ### 3.Search and sort lists ###*/
List<string> names = ["<name>", "zz", "Ana", "Felipe", "bat","Not Found"];
var index = names.IndexOf("Felipe");
if (index == -1)
{
Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else{
Console.WriteLine($"The name {names[index]} is at index {index}");
}
index = names.IndexOf("Not Found");
if (index == -1)
{
Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
Console.WriteLine($"The name {names[index]} is at index {index}");
}
names.Sort();
foreach ( var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}


/* ### 4.Lists of other types ###*/
List<int> fibonacciNumbers = [1, 1];
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(previous + previous2);
foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}

/* ### 5.Challenge ###*/
List<int> fibonacciNumbers = [1, 1];
while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(previous + previous2);
}
foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}