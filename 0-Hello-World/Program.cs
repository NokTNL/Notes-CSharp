// This is how you log lines in the console:
Console.WriteLine("Hello, World!"); // `;` is compulsory in C#, but newlines and spaces in between expressions do not matter

// string literals in C# are in DOUBLE QUOTES
// To declare a variable in C#, you put the variable type first:
string myFriend = "Alice";
// C# can do string concatenation with `+`, which also result in a string:
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