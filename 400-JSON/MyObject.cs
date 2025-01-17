namespace _400_JSON;

public class MyObject
{
    public required string Name { get; init; } = "";
    public int Age { get; init; } = 0;
    public void SayName()
    {
        Console.WriteLine($"My name is {Name}!");
    }
}
