using _220_linq_find_items;

// All of the below only have METHOD syntax unless specified

List<MyRecord> users = [
    new(1, "Alice", Colour.Blue),
    new(2, "Bob", Colour.Yellow),
    new(3, "Charlie", Colour.Red),
    new(100, "Pause", Colour.Red, IsPuttingPauseToSearch: true),
    new(4, "David", Colour.Red),
    new(5, "Eve", Colour.Blue),
];

// `First` return the first item in the enumerable that returns true for an expression, and throws if not found
// `FirstOrDefault` does the same but instead return the provided default value if not found (or `null` if not provided)

MyRecord userNamedEve = users.First(user => user.Name == "Eve");
Console.WriteLine("Found a user named Eve:");
Console.WriteLine($"{userNamedEve.Id}: {userNamedEve.Name} {userNamedEve.FavColour}");
// MyRecord userNamedNotFound = users.First(user => user.Name == "Invalid Name"); // This will throw error
const string invalidName = "Invalid Name";
MyRecord? userNamedNotFound = users.FirstOrDefault(user => user.Name == invalidName); // This will return null
if (userNamedNotFound is null)
{
    Console.WriteLine($"Cannot find a user with Name {invalidName}");
}

// There is a similar Last and LastOrDefault, but it searches from the end instead of from the start

// `Single` and `SingleOrDefault` search the whole list and see if there's only one item that satisfies the expression; it throws if there's MORE THAN ONE match
// - `SingleOrDefault` returns default value / null if not found
MyRecord yellowUser = users.Single(user => user.FavColour == Colour.Yellow); // Bob
MyRecord? greenUser = users.SingleOrDefault(user => user.FavColour == Colour.Green); // null

// `Take` takes the first n elements from the enumerable
// `Skip` skips the first n elements and return the remaining
// `Range` slice the list from m-th to n-th element (included)
// `TakeWhile` gets all elements (from the start) which satisfies the expression, and skip the remaining when hitting the first false item
// `SkipWhile` similar except it skips elements
List<MyRecord> usersBeforeSkipping = users.TakeWhile(user => !user.IsPuttingPauseToSearch).ToList();

// `Distinct` gives you the distinct set of values in a certain list
List<Colour> distinctSetOfFavColourFromUsers = users.Select(user => user.FavColour).Distinct().ToList(); // Blue, Yellow, Red