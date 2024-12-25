// This app will evaluate an algebraic expression in order and not respsecting priority
// e.g. 2.3 + 3.5 / 2 = 5.8 / 2 = 2.9
using Exercise_1_Calculator;

while (true) {
    Calculator calculator = new();

    try {
        Console.Write("Type in an expression to calculate (accepts +, -, *, /, ^): ");
        calculator.RawInput = Console.ReadLine()!;
        calculator.Calculate();
        Console.WriteLine($"{calculator.RawInput} equals {calculator.Result}");
    } catch {
        Console.WriteLine("Invalid input.");
    }
}
