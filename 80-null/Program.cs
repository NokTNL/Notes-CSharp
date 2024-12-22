

using _80_null;

// An uninitialised REFERENCE type will have the default value of `null` (similar to the NULL pointer in C)

MyClass myClass; // It has a value of `null` even if we explicitly assign it to the variable;
// myclass.SayHi(); // <--- this will not compile because the compiler knows that it is uninitialised;

// We can actually explicitly assign `null` to it to make it compile, but ...
// ... calling anything on null will cause a nullReferenceError at runtime
myClass = null;
// myClass.SayHi(); // <-- nullReferenceError

// If we need to use null somewhere in the code (e.g. if something is optional), we need to check if it is null or not
// The easiest way is just `== null`

static void SayHiWithNullCheck(MyClass? arg_myClass) // `MyClass?` to tell the compiler that it could tak `null`
                                                     // Just `MyClass` will still work but less safe
{
    if (arg_myClass == null)
    {
        Console.WriteLine("Your class is null!");
    }
    else{
        arg_myClass.SayHi(); // The compiler is smart enough to see that we have checked `arg_myClass` is not null above, so no warnings here
    }
}
SayHiWithNullCheck(myClass);

// VALUE types cannot take `null` unless we make it into a nullable value type
int? a;
a = null;

static int AddOne (int? num) // !!! This is DIFFERENT from optional arguments, which does not need to specify an argument at all and must provide a default value
{
    // There are multiple ways to check if a value type is null
    // `==` and `!=`
    if (num != null)
    {
        // return num + 1; // <-- Incorrect; compiler still thinks it is of `int?` type
        return num.Value + 1; // `.Value` is present for all nullable value types
    }
    // `.HasValue`, which is present for all nullable value types
    if (num.HasValue)
    {
        return num.Value + 1;
    }

    // Null-coalescing operator `??`; only use the right-hand expression when the left-hand side is null
    int sanitisedNum = num ?? 0;
    
    return sanitisedNum + 1;
}