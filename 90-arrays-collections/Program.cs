﻿/*
 * Lists (preferred)
 */
// Lists are one of the many "Collections" provided by .NET (not C# built-in, unlike arrays).
// It represents a collection of objects of the same type
// You can use the "Collection Intialiser" syntax `new() {}` to assign values
List<int> myListOfInts = new() { 1, 2, 3, 4 };

// From C# 12, you can also use the "Collection Expression" syntax `[]` to "collect values" for a list
// It can be used anywhere that accepts the collection initialiser `new() {}`, and Arrays (see below)
List<int> myListOfInts3 = [1, 2, 3, 4];
                                        
// Empty list
List<int> myEmptyListOfInts = new();
// Using []:
myEmptyListOfInts = [];

// List items can be retrieved by index
Console.WriteLine($"myListOfInts[2]: {myListOfInts[2]}"); // 3
// You can then call these methods / fields:
// - Add (add an item to the end)
// - Remove (remove the first occurence of an item)
// - RemoveAt, Insert
// - Count (get the length of the list)
// ...


/*
 * Arrays
 */
// Arrays in C# have fixed length once initilaised
// We can use the "array initializer" syntax `{}` to create an array (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/arrays#177-array-initializers)
int[] myArray3 = {1, 2, 3, 4};
// We can also use new collection expression `[]`
int[] mySecondArray = [1, 2, 3, 4];

// Remember that these arrays are of fixed length, and (unfortunately) the compiler is not smart enough to pick it up if you try to access out-of-range items
// Console.WriteLine(myFirstArray[6]); // <-- This throws RUNTIME error

// You can also declare an empty array without the actual values; These will be filled with the type's default value (e.g. 0 for int)
int[] myEmptyArray = new int[4];
Console.WriteLine(myEmptyArray[2]); // 0

// Even though arrays are of fixed length, it can be fixed at runtime.
int arrayLength;
do
{
    Console.Write("Give an array length: ");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out arrayLength) || arrayLength == 0)
    {
        Console.WriteLine("Invalid length.");
        arrayLength = 0;
    }
} while (arrayLength == 0);
Console.WriteLine($"Just created an empty boolean array of length {arrayLength}:");
bool[] myBoolArray =  new bool[arrayLength];
for (int i = 0; i < arrayLength; ++i)
{
    Console.WriteLine(myBoolArray[i]);
}