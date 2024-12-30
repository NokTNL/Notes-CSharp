using System;

namespace _210_linq_order_filter;

enum Colour {
    Red,
    Blue,
    Yellow,
}

record MyRecord(int Id, string Name, Colour FavColour);