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
    /*
     * Fields
     */
    // Fields are simply variables belonging to a class
    // Naming conventions:
    public string FirstName = "";
    private string _lastName = "";

    // Syntax of constructor in C# is using the same name as the constructor
    // Note that its parameters cannot have the same name as any fields
    public Employee(string first, string last)
    {
        FirstName = first;
        _lastName = last;
    }

    // Constructors can be overloaded 
    public Employee() {}

    public string GetFullName () {
        return $"{FirstName} {_lastName}";
    }

    /*
     * Properties
     */
    // Properties are getter / setter encapsulation for a field
    // This is the more common way of defining a memeber in a class
    public string ExampleProperty {get; set;} // This is the simplest way to define a property (which you can both read and write)
    
    // If you want to add some extra logic, you can use either a lambda or a usual method notation
    // For example this is how you back the `_lastName` private field:
    public string LastName {
        get => _lastName;
        set => _lastName = value; // Inside a setter you can get the assigned value using the `value`
    }

    // You can add modifiers to the getter / setter, e.g. if you want to make it readonly
    public string LastNameWithRestictions
    {
        get;
        private set; // This will make it readonly outside the class but writable inside the class
    }
}

// More on primary constructors in `EmployeeV2.cs`
