/**
 * Basics and Logging
 */
// This is how you log lines in the console:
Console.WriteLine("Hello, World!"); // `;` is compulsory in C#, but newlines and spaces in between expressions do not matter
// `Console.WriteLine` add a new line at the end. You can use `Console.Write` if you don't want the new line.
// You can also READ line from console; The program will wait on that line (before `;`), wait for user input and then go ahead with running the whole line
Console.WriteLine($"You entered: {Console.ReadLine()}");

/**
 * Literal value types
 */
 // All literla values are IMMUTABLE
Console.WriteLine("Alice"); // string literal uses DOUBLE quotes; using single quotes here will not compile
Console.WriteLine('a');  // charater literal
Console.WriteLine(123); // integer literal
Console.WriteLine(1808080808000); // long integer literal; or you can use `l` or `L` explicitly for smaller numbers
// For floating-point numbers, C# defaults to double precision
Console.WriteLine(25.43); // double; or you can specify it explicitly; d or D will do
Console.WriteLine(0.25f); // single (float); f or F will do
Console.WriteLine(1.32m); // decimal (i.e. EXACT values, up to 28-29 digits); m or M will do
Console.WriteLine(true);  // boolean literal; the value is `true` but printed as `True`

/**
 * Variable declarations
 */
// To declare a variable in C#, you put the variable type first.
// The naming convention is to use camelCase
string myFirstString = "Hi!";
// You can also define IMPLICITLY TYPED variables, which is telling the compiler to apply the type of the literal value assigned to it
// However, the type CANNOT be changed once initialised
var mySecondString = "Bye!"; // Implied `string` type
// `var` must be initialised with value (otherwise god knows what type it is?)
// var noValue; <-- this will throw error
string noValue; // <-- this is fine, and can be reassigned later
// constants can be declared as well. Must be initialised before using, but cannot be changed once initialised
const string myConstant = "some-string";
// myConstant = "new-string"; // won't work