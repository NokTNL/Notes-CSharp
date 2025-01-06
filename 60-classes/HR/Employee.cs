// In C# we group code in namespaces instead of relying on file names.
// - Mulitple files can share the same namespace, which will just add more stuff to the same namesapce
// - The file name also does not matter much because of that
// By using namespaces, you can define things with the same name without worrying about name clashes

/*
 * File-scoped namespaces
 */
// If you only have one namespace in a file, you can use FILE-SCOPED NAMESPACE, and simply put all the class declarations under it (instead of inside brackets).
// It makes it way more readable, but you cannot defined more than one namespaces if you use this.
// Example: 

/*
namesapce Foo;

class Bar
{
     public static void Baz () {}
}

namespace Extra; <--- NOT ALLOWED
*/

/*
 * Namespaces conventions
 */
// - The namespace name is typically just the name of your app.

// - If files are grouped by folders, they will then usually be appended after the app name with a "."
namespace _60_classes.HR;

class Employee {
    public string FirstName = "";
    public string LastName = "";

    // Syntax of constructor in C# is using the same name as the constructor
    // Note that its parameters cannot have the same name as any fields
    public Employee(string first, string last)
    {
        FirstName = first;
        LastName = last;
    }

    // Constructors can be overloaded 
    public Employee() {}

    public string GetFullName () {
        return $"{FirstName} {LastName}";
    }
}

// More on primary constructors in `EmployeeV2.cs`
