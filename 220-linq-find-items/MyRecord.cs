namespace _220_linq_find_items;

enum Colour {
    Red,
    Blue,
    Yellow,
    Green
}

record MyRecord(
    int Id,
    string Name,
    Colour FavColour,
    bool IsPuttingPauseToSearch = false
);