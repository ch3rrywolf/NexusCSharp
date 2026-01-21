/*
    Basic CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

   Tutorial: Create types in C#.
    1. Tuples.
    2. Create record types.
    3. Struct, class, and interface types.
*/

/*  ### 1.Tuples ###*/
// Tuples are an ordered sequence of values with a fixed length.
// Each element of a tuple has a type and an optional name.
var pt = (X: 1, Y: 2);
var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");
pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}");
var pt2 = pt with { Y = 10 }; // assign a tuple to a tuple with the same arity and types even if the members have different names.
Console.WriteLine($"The point 'pt2' is at {pt2}");
var subscript = (A: 0, B: 0);
subscript = pt; // you declare multiple members enclosed in parentheses, all the following declarations define different tuples with different arities and member types.
Console.WriteLine(subscript);
// tuples are easy to create, they're limited in their capabilities.
// tuple type don't have names, so you can't convey meaning to the set of values.
// tuple types can't add behavoir.
var nameData = (Name: "Morning observation", Temp: 17, Wind: 4);
var person = (FirstName: "", LastName: "");
var order = (ProductHeaderValue: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);
Console.WriteLine($"Name data: {nameData} Person: {person} Order: {order}");
