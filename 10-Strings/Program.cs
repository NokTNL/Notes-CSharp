/**
 * Escape characters & Verbatim string literals
 */
// C# supports escape characters (\n, \t, \\, etc.). 
//  - This can be used in both strings and characters
// This can help if e.g. you want a newline inside a string literal and don't want to error
// But we can also use VERBATIM STRING LITERAL to denote whitesapces "as is" without using escape characters
// Inside a verbatim string literal, the backslash will actually get IGNORED
// The only thign that gets esacped in verbatim string literal is a DOUBLE DOUBLE QUOTE ("") which evaluates to a single double quote
Console.WriteLine(@"Hi!
    This has extra white spaces
This starts from a new line
And backslashes are not escaping anything \n\t\\
And this is how you display a double quote: ""
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

/*
 * String comparison
 */
// Strings can be directly compared with a `==` operator in C#
// Alternatively you can use String.Equals(string)
Console.WriteLine($"\"abc\" == \"abc\" is {"abc" == "abc"}");
Console.WriteLine($"\"abc\".Equals(\"abc\") is {"abc".Equals("abc")}");

/****
 String manipulations
 ****/
// String.Trim: trim leading & trailing white-spaces. If you pass character(s) into the method, it will remove only those characters.
// Strings in C# are immutable (as in most other languages) so all these methods will return a new string instead of changing the original string
string myFriendWithSpaces = "        Bob                ".Trim();
Console.WriteLine($"Hello, {myFriendWithSpaces}!"); // Hello, Bob!

// String.Replace, .Contains, .StartsWith, .EndsWith, .ToUpper, .ToLower

/**
 * String parsing
 */
// Each value type has a `Parse` method for parsing a string into the type
// If `Parse` fails, it will throw a runtime error
Console.WriteLine($"Parsing \"123\" to integer: {int.Parse("123")}"); 
// Console.WriteLine($"Parsing \"abc\" to integer: {int.Parse("abc")}"); // This line throws RUNTIME error

// Alternatively we can use `TryParse` which returns true if the parsing was successful and false when not
if (int.TryParse("abc", out int parsedInt)) { // `out` means where you want to output the parsed result
  Console.WriteLine($"Parsed \"abc\" to {parsedInt}");
} else {
  Console.WriteLine("Parsing \"abc\" to an int unsuccessful");
}