namespace _85_Records;

// `record` is a MODIFIER that makes it ideal for creating "light weight classes" for storing data.
// Shortest way to define a record, using primary constructor:
record Coord(double X, double Y);
// Under the hood, PUBLIC GET-ONLY PROPERTIES are generated for every parameter in the primary constructor
class CoordUnderTheHood(double X, double Y)
{
    public double X { get; init; } = X; // `init` is a setter that can only be called during instantiation (incl. both contructor and object initialiser)
    public double Y { get; init; } = Y;
}
// Notes:
// - They are compared by values (even though records are reference types).
//   - Classes are compared by reference, so two objects can be unequal because they point to two different object instance, even when the two instances have the exact same content
//   - Source: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record#value-equality
