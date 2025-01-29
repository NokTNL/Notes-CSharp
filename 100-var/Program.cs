using _100_var.HR;

/**
 * `var` for classes & anonymous types
 */
// `var` can imply the type from the constructor on the right hand side
var myEmptyEmployee = new Employee();
// Using with object initialisers
var myEmployee = new Employee // No need () here if the constructor is not called with any arguments
{
    FirstName = "John",
    LastName = "Doe"
};

// You can use object initialisers to define ANONYMOUS TYPES, which is a read-only object without being created from an explicit class
// - It uses `new` WITHOUT a class name
// - It MUST be assigned to a `var` if you want to reuse the value later
var anonymousObj = new { Foo = "Bar", Baz = 42 };
// anonymousObj.Foo = "Baz"; // Error

// C# can even infer member names from the value name
var FirstName = myEmployee.FirstName;
var anonymousEmployee = new { FirstName, myEmployee.LastName }; // This will be of type { string FirstName, string LastName }

/**
 * `var` for Arrays and Lists
 */
// `var` can imply type of an ARRAY (not Lists!) if you use `new[]`
var numArray = new[] { 1, 2, 3 }; // This is of type int[]
// Lists
var numList = new List<int> { 1, 2, 3 };
// !!! You cannot directly define a `var` by collection expression []. Use explicit types for that.
// var numList = [ 1, 2, 3 ]; // This won't work (or anything similar to this)
