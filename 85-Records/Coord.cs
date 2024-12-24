namespace _85_Records;

// Records are like a light weight class that only contains fields.
// - It cannot contain methods
// - You do not need to create fields for it (although you can); just list them all in a primary constructor
// - The fields are readonly by default (you CAN make it mutable but will be rare use case)
// - They are compared by values (even though records are reference types).
//   - Classes are compared by reference, so two objects can be unequal because they point to two different object instance, even when the two instances have the exact same content
record Coord(double X, double Y);