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
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

/* ### 2.Modify list contents ###*/