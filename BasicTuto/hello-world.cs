/*
    Basic CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

   Tutorial: Explore the C# language. 
    1. Declare and use variables.
    2. Work with strings.
    3. Remove whitespace from strings.
    4. Search and replace text in string.
    5. Challenge.
*/


 Console.WriteLine("Hello, World!");

//  ### 1.Declare and use variables ###
string aFriend = "Bill";
Console.WriteLine("Hello " + aFriend);
aFriend = "Maria";
Console.WriteLine("Hello " + aFriend); 
Console.WriteLine($"Hello {aFriend}"); // String interpolation

//  ### 2.Work with strings ###
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} lettres."); // try .Length is a property of a string and it returns the number of caracters in that string.
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} lettres.");

//  ### 3.Remove whitespace from strings ###
string greeting = "       Hello World!       ";
Console.WriteLine($"[{greeting}]");
string trimmedGreeting = greeting.TrimStart(); // .TrimStart() remove all Start espace
Console.WriteLine($"[{trimmedGreeting}]");
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]"); // .TrimEnd() remove all End espace
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]"); // .Trim() remove all Start and End espace

//  ### 4.Search and replace text in string ###
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings"); // .Replace("search", "replace") this get two parameters one to search and one to replace.
Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper()); // .ToUpper() make a string all caps.
Console.WriteLine(sayHello.ToLower()); // .ToLower() make a string all lowercase.
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye")); // .Contains() method for searching but return boolean "True" or "False".
Console.WriteLine(songLyrics.Contains("greetings"));

//  ### 5.Challenge ### 
/*Try to modify the previous sample to use StartsWith and EndsWith instead of Contains.
Search for "You" or "goodbye" at the beginning of a string.
Search for "hello" or "goodbye" at the end of a string.*/
// Solution:
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.StartsWith("You")); // .StartsWith() search for substring in a Starts string
Console.WriteLine(songLyrics.StartsWith("goodbye"));
Console.WriteLine(songLyrics.EndsWith("hello")); // .Ends() search for substring in a Ends string
Console.WriteLine(songLyrics.EndsWith("goodbye"));