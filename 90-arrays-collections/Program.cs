// In C#, an "Array" refers to a fixed-length array, while a "List" refers to a dynamic length one.

/*
 * Lists (preferred)
 */
// Lists are one of the many "Collections" provided by .NET (not C# built-in, unlike arrays)
List<int> myListOfInts = [1, 2, 3, 4]; // `[]` is called the "collection expression"; use it to assign a list of values to any IEnumerable (e.g. List and arrays)
// We can also use the "Collection initialiser" syntax
myListOfInts = new List<int> {1, 2, 3, 4};
// or simply
myListOfInts = new {1, 2, 3, 4};

List<int> myEmptyListOfInts = []; // Empty list 
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
// To declare an array:
int[] myFirstArray = new {1, 2, 3, 4}; // You can also use [] instead of {} from C# 12
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