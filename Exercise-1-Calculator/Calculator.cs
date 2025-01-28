namespace Exercise_1_Calculator;

public class Calculator
{
    public string Input { get; set; } = "";
    public double Result { get; private set; } = 0;

    private void ApplyOperation (string numberString, char operatorChar)
    {
        double currentNumber = double.Parse(numberString);
        if (operatorChar == '\0')
        {
            Result = currentNumber;
        }
        else
        {
            switch(operatorChar)
            {
                case '+':
                    Result += currentNumber;
                    break;
                case '-':
                    Result -= currentNumber;
                    break;
                case '*':
                    Result *= currentNumber;
                    break;
                case '/':
                    Result /= currentNumber;
                    break;
                case '^':
                    Result = Math.Pow(Result, currentNumber);
                    break;
            }
        }
    }
    public double Calculate()
    {
        string inputWithoutSpace = Input.Replace(" ", "");
        string lastNumberString = "";
        char lastOperator = '\0';
        foreach (char currentChar in inputWithoutSpace)
        {
            if (char.IsDigit(currentChar) || currentChar == '.')
            {
                lastNumberString += currentChar;
            }
            else if ("+-*/^".Contains(currentChar))
            {
                ApplyOperation(lastNumberString, lastOperator);
                lastNumberString = "";
                lastOperator = currentChar;
            }
            else throw new FormatException();
        }
        ApplyOperation(lastNumberString, lastOperator);
        
        return Result;
    } 
}
