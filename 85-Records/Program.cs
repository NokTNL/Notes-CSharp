using _85_Records;

// Use a record just like a class
Coord coord1 = new(1.23, 4.56);
Coord coord2 = new(1.23, 4.56);
Console.WriteLine(coord1.X); // 1.23
// coord1.X = 123; // Error, readonlt
Console.WriteLine(coord1 == coord2); // True
