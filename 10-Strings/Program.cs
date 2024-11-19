/**
 * Escape characters
 */
// C# supports escape characters (\n, \t, \\, etc.). 
//  - This can be used in both strings and characters
// This can help if e.g. you want a newline inside a string literal and don't want to error
// But we can also use VERBATIM STRING LITERAL to denote whitesapces "as is" without using escape characters
// Inside a verbatim string literal, the backslash will actually get IGNORED
Console.WriteLine(@"Hi!
    This has extra white spaces
This starts from a new line
And backslashes are not escaping anything \n\t\\
");
// Unicode escape characters    
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // こんにちは World!

/**
 * String Concatenation & Interpolation
 */
// C# can do string concatenation with `+`, which also result in a string:
string myFriend = "Alice";
Console.WriteLine("Hello, " + myFriend + "!");
// C# has string interpolations:
Console.WriteLine($"Hello again, {myFriend}!");
// It can be mixed with verbatim tempalte literal
Console.WriteLine($@"Hello, {myFriend} is trying to...
  ...escape to a new line");

/****
 String manipulations
 ****/
// String.Trim: trim leading & trailing white-spaces. If you pass character(s) into the method, it will remove only those characters.
// Strings in C# are immutable (as in most other languages) so all these methods will return a new string instead of changing the original string
string myFriendWithSpaces = "        Bob                ".Trim();
Console.WriteLine($"Hello, {myFriendWithSpaces}!"); // Hello, Bob!

// String.Replace, .Contains, .StartsWith, .EndsWith, .ToUpper, .ToLower