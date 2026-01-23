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
/*List<string> names = ["<name>", "Ana", "Felipe"];
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
*/

/* ### 2.Modify list contents ###*/
List<string> names = ["<name>", "Ana", "Felipe"];
Console.WriteLine();
names.Add("Maria"); // added a name
names.Add("Bill");
names.Remove("Ana"); // removed a name
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!"); // printed all names resulting list
    Console.WriteLine($"My name is {names[0]}"); // accessed first list item
    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list."); // accessed specific list items
    Console.WriteLine($"The list has {names.Count} people in it."); // printed list count
}