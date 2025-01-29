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
// !!! Collection expressions [] cannot have type inferenced for `var`. Use explicit types for that.
// var numList = [ 1, 2, 3 ]; // This won't work (or anything similar to this)

// SUMMARY on various similar initialisers syntaxes:
// Context           \ Type
//                   | Classes                 | Collections                         | Arrays
// Explicit type     | MyClass foo = new()     | List<int> foo = new() {1,2,3,4}     | int[] foo = {1,2,3,4}
// (on the left)     | MyClass foo = new() {   | List<int> foo = [1,2,3,4]           | int[] foo = [1,2,3,4]
//                   |   Foo = "bar"           |                                     | int[] foo = int[4]
//                   | }                       |                                     |
// __________________|_________________________|_____________________________________|_________________________________
// var               | var foo = new MyClass() | var foo = new List<int> {1,2,3,4}   | var foo = new int[] {1,2,3,4}
// (type on the      | var foo = new MyClass { |                                     | var foo = new int[4]
// right)            |   Foo = "bar"           |                                     |
//                   | }                       |                                     |
//___________________|_________________________|_____________________________________|_________________________________
// Implicitly typed  | new {                   | -                                   | new[] {1,2,3,4}
// values            |   Foo = "bar"           |                                     | 
//                   | }                       |                                     |
