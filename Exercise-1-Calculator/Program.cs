// This app will evaluate an algebraic expression in order and not respsecting priority
// Accepted operations: +, -, *, /, ^
// e.g. 2.3 + 3.5 / 2 = 5.8 / 2 = 2.9
using Exercise_1_Calculator;

Calculator calculator = new();

while (true) {
    try {
        Console.Write("Type in an expression to calculate (accepts +, -, *, /, ^): ");
        calculator.Input = Console.ReadLine()!;
        calculator.Calculate();
        Console.WriteLine($"{calculator.Input} equals {calculator.Result}");
    } catch {
        Console.WriteLine("Invalid input.");
    }
}
