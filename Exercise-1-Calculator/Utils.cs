namespace Utils;

class StringOp
{
    public static string[] SplitToNumbers (string expression) => expression
        .Replace(" " , "")
        .Split('+', '-', '*', '/');
}