/*
    Basic CSharp (C#) learn with @ch3rrywolf.exe
    ##### ###### #### ##### #### ###############

   Tutorial: The C# type system.
    1. Specifying types in variable declarations.
    2. Built-in types.
    3. Custom types.
    4. The common type system.
    5. Value types.
    6. Reference types.
    7. Types of literal values.
    8. Generic types.
    9. Tuples and anonymous types.
    10. Nullable value types.
    11. Implicit type declarations.
    12. Compile-time type and run-time type.
*/


// If you declare a variable of type int,
// the compiler allows you to use the variable in addition and subtraction operations.
// If you try to perform those same operations on a variable of type bool,
// the compiler generates an error.
int a = 5;
int b = a + 2; //OK
bool test = true;
// Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
int c = a + test;
// bool isn't convertible to int.


/* ### 1. Specifying types in variable declarations. ###*/
// When you declare a variable or constant in a program,
// you must either specify its type or use the var keyword to let the compiler infer the type.
// Declaration only:
float temperature;
string name;
MyClass myClass;
// Declaration with initializers (four examples):
char firstLetter = 'C';
var limit = 3;
int[] source = [0, 1, 2, 3, 4, 5];
var query = from item in source
            where item <= limit
            select item;
// You specify the types of method parameters and return values in the method declaration.
public string GetName(int ID)
{
    if (ID < names.Length)
        return names[ID];
    else
        return String.Empty;
}
private string[] names = ["Spencer", "Sally", "Doug"];
// After you declare a variable, you can't redeclare it with a new type, and you can't assign a value that's incompatible with its declared type.
// For example, you can't declare an int and then assign it a Boolean value of true .
// However, you can convert values to other types, such aswhen you assign them to new variables or pass them as method arguments.
// The compilerautomatically performs a type conversion that doesn't cause data loss.
// A conversion that might cause data loss requires a cast in the source code.


/* ### 2. Built-in types. ###*/
// hese types represent integers, floating point values, Boolean expressions, text characters, decimal values, and other types of data.
// The language also includes built-in string and object types.


/* ### 3. Custom types. ###*/
// Create structural types by using tuples for storing related data members.
// These types provide a structure that holds multiple members.
// Tuples have limited behavior.
// They're a container for values.
// These are the simplest types you can create.
// You might later decide you need behavior.
// In that case, you can convert a tuple to either a struct or class.
// Use the struct, class, interface, enum, and record constructs to create your own custom types.
// . If the data type isn't part of your app domain and doesn't include behavior, use a structural type.
// . If the data storage size is small, no more than 64 bytes, choose a struct or record struct.
// . If the type is immutable, or you want nondestructive mutation, choose a struct or record struct.
// . If your type should have value semantics for equality, choose a record class or record struct.
// . If the type is primarily for storing data, with minimal behavior, choose a record class or record struct.
// . If the type is part of an inheritance hierarchy, choose a record class or a class.
// . If the type uses polymorphism, choose a class.
// . If the primary purpose is behavior, choose a class.
// You can also choose an interface to model a contract: behavior described by members that can be implemented by unrelated types.
// Interfaces are abstract and declare members that must be implemented by all class or struct types that inherit from that interface.


/* ### 4. The common type system. ###*/
// All types, including built-in numeric types such as System.Int32 (C# keyword: int ),
// ultimately derive from a single base type, which is System.Object (C# keyword: object).
// This unified type hierarchy is called the Common Type System (CTS).
// Each type in the CTS is defined as either a value type or a reference type.
// . Types that you define by using the struct or record struct keywords are value types. 
// All the built-in numeric types are structs.
// . Types that you define by using the class , record class , or record keywords are reference types.
// The most commonly used types are all organized in the System namespace. However, the namespace in which a type is contained has no relation to whether it's a value type or reference type.
// A class, struct, or record declaration is like a blueprint that you use to create instances or objects at run time.
// .. A class is a reference type. When you create an object of the type, the variable to which you assign the object holds only a reference to that memory. When you assign the object reference to a new variable, the new variable refers to the original object. Changes you make through one variable are reflected in the other variable because they both refer to the same data.
// .. A struct is a value type. When you create a struct, the variable to which you assign the struct holds the struct's actual data. When you assign the struct to a new variable, it's copied. The new variable and the original variable therefore contain two separate copies of the same data. Changes you make to one copy don't affect the other copy.
// .. Record types can be either reference types ( record class ) or value types ( record struct ). Record types contain methods that support value-equality.
// In general, use classes to model more complex behavior.
// Classes typically store data that you modify after a class object is created. Structs are best suited for small data structures.
// Structs typically store data that you don't modify after the struct is created.
// Record types are data structures with extra compiler synthesized members.
// Records typically store data that you don't modify after the object is created.


/* ### 5. Value types. ###*/
// Value types derive from System.ValueType, which derives from System.Object.
// Types that derive from System.ValueType have special behavior in the CLR.
// Value type variables directly contain their values.
// The memory for a struct is allocated inline in whatever context the variable is declared.
// You can declare record struct types that are value types and include the synthesized members for records.
// Two categories of value types exist: struct and enum.
// The built-in numeric types are structs, and they have fields and methods that you can access.
// constant field on type 
byte.byte b = byte.MaxValue;
// But you declare and assign values to them as if they're simple non-aggregate types:
byte num = 0xA;
int i = 5;
char c = 'Z';
// Value types are sealed. You can't derive a type from any value type, such as System.Int32.
// You can't define a struct to inherit from any user-defined class or struct because a struct can only inherit from System.ValueType.
// a struct can implement one or more interfaces. You can cast a struct type to any interface type that it implements.
// This cast causes a boxing operation to wrap the struct inside a reference type object on the managed heap.
// Boxing operations occur when you pass a value type to a method that takes a System.Object or any interface type as an input parameter.
// Use the struct keyword to create your own custom value types. Typically, a struct is used as a container for a small set of related variables.
public struct Coords(int x, int y)
{
    public int X { get; init; } = x;
    public int Y { get; init; } = y;
}
// An enum defines a set of named integral constants.
public enum FileMode
{
    CreateNew = 1,
    Create = 2,
    Open = 3,
    OpenOrCreate = 4,
    Truncate = 5, Append = 6,
}
// The System.IO.FileMode.Create constant has a value of 2.
// the name is much more meaningful for humans reading the source code, and for that reason it's better to use enumerations instead of constant literal numbers.
// All enums inherit from System.Enum, which inherits from System.ValueType. All the rules that apply to structs also apply to enums.


/* ### 6. Reference types. ###*/
// A type that you define as a class , record class , record , delegate, array, or interface is a reference type.
// When you declare a variable of a reference type, it contains the value null until you assign it with an instance of that type or create one by using the new operator.
MyClass myClass = new();
MyClass myClass2 = myClass;
// You can't directly instantiate an interface by using the new operator. Instead, create and assign an instance of a class that implements the interface.
MyClass myClass = new();
// Declare and assign using an existing value.
IMyInterface myInterface = myClass;
// Or create and assign a value in a single statement.
IMyInterface myInterface2 = new MyClass();
// When you create the object, the system allocates memory on the managed heap.
// The variable holds only a reference to the location of the object.
// Types on the managed heap require overhead both when they're allocated and when they're reclaimed.
// Garbage collection is the automatic memory management functionality of the CLR, which performs the reclamation.
// However, garbage collection is also highly optimized, and in most scenarios it doesn't create aperformance issue.
// All arrays are reference types, even if their elements are value types. Arrays implicitly derive from the System.Array class.
// Declare and initialize an array of integers.
int[] nums = [1, 2, 3, 4, 5];
// Access an instance property of System.Array.
int len = nums.Length;
// Reference types fully support inheritance.
// When you create a class, you can inherit from any other interface or class that isn't defined as sealed.
// Other classes can inherit from your class and override your virtual methods.


/* ### 7. Types of literal values. ###*/
// In C#, the compiler assigns a type to literal values.
// You can specify how a numeric literal should be typed by appending a letter to the end of the number.
// For example, to specify that the value 4.56 should be treated as a float , append an "f" or "F" after the number: 4.56f . If you don't append a letter, the compiler infers a type for the literal.
// Because literals are typed, and all types ultimately derive from System.Object.
string s = "The answer is " + 5.ToString();
// Outputs: "The answer is 5"
Console.WriteLine(s);
Type type = 12345.GetType();
// Outputs: "System.Int32"
Console.WriteLine(type);


/* ### 8. Generic types. ###*/
// Declare a type with one or more type parameters that act as placeholders for the actual type (the concrete type).
// Client code provides the concrete type when it creates an instance of the type. These types are called generic types.
// For example, the .NET type System.Collections.Generic.List<T> has one type parameter that by convention is named T.
// When you create an instance of the type, you specify the type of the objects that the list contains, such as string.
List<string> stringList = new List<string>();
stringList.Add("String example");
// compile time error adding a type other than a string:
stringList.Add(4);
// Using the type parameter makes it possible to reuse the same class to hold any type of element, without having to convert each element to object.
// Generic collection classes are strongly typed collections because the compiler knows the specific type of the collection's elements and can raise an error at compile time if.
// or example, you try to add an integer to the stringList object in the previous example.