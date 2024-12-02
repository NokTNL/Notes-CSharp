/**
 * Switch statements
 */
// Switch statements in C# supports RELATION PATTERNS as well as CONSTANT PATTERNS in cases
// C# switch CANNOT fall through; it will ensure that only one case block is executed
// *** Switch statements are preferred over if...else in C# for better performance when compiled
int age = 68;
switch (age)
{
    case <= 15:
        Console.WriteLine("Children");
        break; // !!! C# switch does not allow fall through if you run anything inside a case, and `break` must be used (or it will throw an error)
    // However, you can have multiple cases sharing one block:
    case 16:
    case 17:
        Console.WriteLine("Almost adult");
        break;
    case >= 18 and < 65: // !! You use `and` and `or` here instead of `&&` and `||`
        Console.WriteLine("Adult");
        break;
    case >= 65:
        Console.WriteLine("Senior");
        break;
    // The compiler is also smart enough to tell you that all the cases has been handled above and the following code is unreachable (and can throw an error):
    default:
        Console.WriteLine("Invalid age");
        break; // !!! You also cannot omit break statement in the default case
}