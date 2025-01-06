using _60_classes.HR;

/**
 * `using` namespaces
 */
// To use members inside a namespace, you have two choices:
// 1. `using` a namespace + just the class name:
var myEmployee = new Employee("Adam", "Smith");
// If there are ambiguous cases (i.e. two namespaces have members with the same name), you can:
// 2. Use aliases:
//   - using HR = _60_classes.HR;
//     new HR.Employee();
//   OR:
//   - using HREMployee = _60_classes.HR.Employee;
//     new HREMployee();
// 3. Use the fully qualified name at where you are using it (no need `using` in this case):
//   `_60_classes.HR.Employee`
Console.WriteLine(myEmployee.GetFullName());

/*
 * Object initialisers
 */
 // If your class has fields accessible in the current context (not just `public`), you can assign to them striaght away using object initialisers
 var mySecondEmployee = new Employee()
 {
    FirstName = "John",
    LastName = "Doe"
 };
 // or
 mySecondEmployee = new()
{
    FirstName = "John",
    LastName = "Doe"
};
// instead of
var myThirdEmployee = new Employee();
myThirdEmployee.FirstName = "John";
myThirdEmployee.LastName = "Doe";

// This enables us to define ANONYMOUS TYPES, which is a read-only object without created from an explicit class
var anonymousObj = new { Foo = "Bar", Baz = 42 };
// anonymousObj.Foo = "Baz"; // Error

// C# can even infer member names from the value name
var FirstName = myEmployee.FirstName;
var anonymousEmployee = new { FirstName, myEmployee.LastName }; // This will be of type { string FirstName; string LastName }
