namespace MyClasses;

class Employee {
    public string firstName;
    public string lastName;

    // Syntax of constructor in C# is using the same name as the constructor
    // Note that its parameters cannot have the same name as any fields
    public Employee(string first, string last)
    {
        firstName = first;
        lastName = last;
    }

    public string GetFullName () {
        return $"{firstName} {lastName}";
    }
}

// From C# v12, you can use a more concise PRIMARY CONSTRUCTOR syntax
class EmployeeV2 (string first, string last) {
    public string firstName = first;
    public string lastName = last;
}
