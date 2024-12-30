using _210_linq_order_filter;

List<MyRecord> users = [
    new(1, "Alice", Colour.Blue),
    new(5, "Eve", Colour.Blue),
    new(2, "Bob", Colour.Yellow),
    new(4, "David", Colour.Red),
    new(3, "Charlie", Colour.Red)
];

// Ordering entries (ascending)
List<MyRecord> usersOrderedById = (from user in users
                                    orderby user.Id
                                    select user
                                  ).ToList();
usersOrderedById = users.OrderBy(user => user.Id).ToList(); // No need `Select` in method syntax
Console.WriteLine("All users ordered by ID:");
foreach(var user in usersOrderedById)
{
    Console.WriteLine($"{user.Id}: {user.Name}");
}

// Descending ordering
List<MyRecord> usersOrderByIdDescending = (
    from user in users
    orderby user.Id descending
    select user
).ToList();
usersOrderByIdDescending = users.OrderByDescending(user => user.Id).ToList();
Console.WriteLine("\nAll users ordered by ID (descending):");
foreach(var user in usersOrderByIdDescending)
{
    Console.WriteLine($"{user.Id}: {user.Name}");
}

// Ordering two fields at once
List<MyRecord> usersSortedByColoutAndId = (
    from user in users
    orderby user.FavColour, user.Id
    select user
).ToList();
usersSortedByColoutAndId = users
                            .OrderBy(user => user.FavColour)
                            .ThenBy(user => user.Id)
                            .ToList();
Console.WriteLine("\nAll users ordered by colour and Id:");
foreach(var user in usersSortedByColoutAndId)
{
    Console.WriteLine($"{user.Id}: {user.Name} {user.FavColour}");
}

// Filtering using `where`. The expression after it should return a boolean value
List<MyRecord> onlyRedUsers = (
    from user in users
    where user.FavColour == Colour.Red
    orderby user.Id
    select user
).ToList();
onlyRedUsers = users
                .Where(user => user.FavColour == Colour.Red)
                .OrderBy(user => user.Id)
                .ToList();
Console.WriteLine("\nAll users with red as favourite colour:");
foreach(var user in onlyRedUsers)
{
    Console.WriteLine($"{user.Id}: {user.Name} {user.FavColour}");
}