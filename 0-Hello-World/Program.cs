/**
 * Basics and Logging
 */
// This is how you log lines in the console:
Console.WriteLine("Hello, World!"); // `;` is compulsory in C#, but newlines and spaces in between expressions do not matter
// `Console.WriteLine` add a new line at the end. You can use `Console.Write` if you don't want the new line.

/**
 * Literal value types
 */
 // All literla values are IMMUTABLE
Console.WriteLine("Alice"); // string literal uses DOUBLE quotes; using single quotes here will not compile
Console.WriteLine('a');  // charater literal
Console.WriteLine(123); // integer literal
// For floating-point numbers, C# defaults to double precision
Console.WriteLine(25.43); // double
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




/**
 * Strings
 */
 // string literals in C# are in DOUBLE QUOTES ("") only; single quotes (') are for characters
// C# can do string concatenation with `+`, which also result in a string:
string myFriend = "Alice";
Console.WriteLine("Hello, " + myFriend + "!");
// C# has string interpolations:
Console.WriteLine($"Hello again, {myFriend}!");

/****
 String manipulations
 ****/
// String.Trim: trim leading & trailing white-spaces. If you pass character(s) into the method, it will remove only those characters.
// Strings in C# are immutable (as in most other languages) so all these methods will return a new string instead of changing the original string
string myFriendWithSpaces = "        Bob                ".Trim();
Console.WriteLine($"Hello, {myFriendWithSpaces}!"); // Hello, Bob!

// String.Replace, .Contains, .StartsWith, .EndsWith, .ToUpper, .ToLower