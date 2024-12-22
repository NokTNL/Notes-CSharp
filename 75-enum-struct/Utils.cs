namespace Utils;

/*
 * Enums
 */
// enums allow you to define a group of aliases to prevent "magic numbers"
// Enums are VALUE type in C#
enum ErrorCode {
    TypeError, // 0 
    ValueError, // 1
    ReferenceError // 2 --> these are represented by integers under the hood. You can also explicitly assign an int value here
}

/*
 * Structs
 */
// Structs in C# are very similar to classes.
// - They have constructors and instantiated by `new`
// - They have fields and (even) methods
// The main difference is that structs are VALUE types so the whole struct is copied whenever they are passed around
// There are very few cases that you would need a struct instead of a class in C#
struct Coords (double x, double y){
    public double x = x;
    public double y = y;
}
