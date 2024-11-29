
// Types in C# are actually objects (structs to be precise) themselves and can have a lot of useful built-in members
// `int` can have these, for example:
Console.WriteLine(int.MaxValue); // 2147483647
Console.WriteLine(int.MinValue); // -2147483648

/**
 * Type conversions
 */
// Types can be IMPLICITLY converted
int myInt = 123;
long myLong = myInt; // `int` converted to `long` implicitly, because it is guaranteed to have no loss of info
// int mySecondInt = myLong; // this can potentially have loss of info so is not converted implicitly and will error

// In this case, you need to EXPLICITLY convert it, aka "casting" it
long myLong2 = 18000000000000;
Console.WriteLine((int) myLong2); // -207937536; the long variable overflowed

double myDouble = 123.456789;
Console.WriteLine((int) myDouble); // 123; the decimal part was truncated

/**
 * Overflow
 */
// Casting into a larger data type can help preventing overflows:
int b = 2100000000;
int c = 2100000000;
Console.WriteLine(b + c); // -94967296; adding these two `int`'s overflows
// You can cast them separately to tell the compiler to reserve a bigger sapce for it in advance:
Console.WriteLine((long)b + (long)c); // 4200000000

// Alternatively you can add `checked`, so any arithemtic operations that will overflow will throw a RUNTIME ERROR
long d = checked(b + c); // Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.