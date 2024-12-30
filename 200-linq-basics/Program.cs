// LINQ (Language Integrated Query) is a built-in C# features for querying "array-like" data.
// It has a syntax very similar to SQL. In fact you can it to query databases directly.
// Only objects implementing IEnumerable and IQueryable can be queried using LINQ. Examples:
// - IEnumerable: List, Array

using _200_linq_basics;

List<MyRecord> users = [
    new(1, "Alice"), // `MyRecord` is already known from type, so no need the Record name below
    new(2, "Bob"),
    new(3, "Charlie"),
    new(4, "David"),
    new(5, "Eve"),
];

// LINQ has two syntaxes:
// - QUERY syntax: surround the query with (). You can then immediately turn it into of list or array
// e.g. this will return the same list (`select` MAPS each object in the list into a new object, but it simply returns the object untouched here>
List<MyRecord> allUsers = (from user in users select user).ToList();
// - METHOD syntax: you call the query directly on the list as methods, then pass in a lambda to process it
allUsers = users.Select(user => user).ToList();
Console.WriteLine("All users:");
foreach (MyRecord user in allUsers)
{
    Console.WriteLine($"{user.Id}: {user.Name}");
}

// To select a single "column":
List<string> allUserNames = (from user in users select user.Name).ToList(); // query syntax
allUserNames = users.Select(user => user.Name).ToList(); // method syntax
Console.WriteLine("\nAll user names:");
foreach (var userName in allUserNames)
{
    Console.WriteLine(userName);
}

// You can map the data to new types of objects in `select`
var userNameCharacterCounts = (from user in users
                                select new { // Using anonymous type here so we don't need to define a new class / record
                                    user.Id, // Using "inferred member name" here
                                    NameCharacterCount = user.Name.Length
                                }
                              ).ToList();
userNameCharacterCounts = users.Select(user => new {
                            user.Id,
                            NameCharacterCount = user.Name.Length
                          }).ToList();

Console.WriteLine("\nAll users with name character counts:");
foreach (var user in userNameCharacterCounts)
{
    Console.WriteLine($"{user.Id}: {user.NameCharacterCount}");
}