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