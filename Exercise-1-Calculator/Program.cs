// This will evaluate an expression up to 2 numbers with one operator, e.g. "12.5 / 6.0"
using Utils;

while (true) {
    try {
        Console.Write("Type in an expression to calculate: ");
        var rawInput = Console.ReadLine();
        var subStringsFromInput = StringOp.SplitToNumbers(rawInput);
        var result = double.Parse(subStringsFromInput[0]);
        if (subStringsFromInput.Length > 1) {
            var secondNum = double.Parse(subStringsFromInput[1]);
            if (rawInput.Contains('+')) {
                result += secondNum;
            }
            else if (rawInput.Contains('-')) {
                result -= secondNum;
            }
            else if (rawInput.Contains('*')) {
                result *= secondNum;
            }
            else if (rawInput.Contains('/')) {
                result /= secondNum;
            }
        }
        Console.WriteLine($"{rawInput} equals {result}");
    } catch {
        Console.WriteLine("Invalid input.");
    }
}
