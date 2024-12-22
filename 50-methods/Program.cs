// We want to use a class from another file. In C#, you group code in namespaces and you "use" the namespaces. (More on namespaces later)
// More info about methods in `Utils.cs`
using Utils;

Console.WriteLine($"2 + 3 = {NumberUtils.AddTwoInt(2, 3)}"); // 2 + 3 = 5
ConsoleUtils.SayHi();      // "Hi Mom!"
ConsoleUtils.SayHi("Dad"); // Hi Dad!
ConsoleUtils.SmartSayHi(); // Hi barbie!
ConsoleUtils.SmartSayHi("Ken"); // Hi Ken!
// C# supports NAMED ARGUMENTS, so you don't need call arguments in order
Console.WriteLine($"10 + 20 = {NumberUtils.AddTwoInt(b: 20, a: 10)}"); // 10 + 20 = 30

// Methods can also be defined top-level in this file
static void SayMain() {
    Console.WriteLine("Hi I'm in the Main class!");
}
SayMain(); // Hi I'm in the Main class!

// If you wonder why this "method" is not inside a class
// This is because from v10, C# implicitly creates a class in the entry point file which wraps all the top-level code inside its `Main` method, and run that method when starting up
// All the top-level methods will become methods of that internally created class