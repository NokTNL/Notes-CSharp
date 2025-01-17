namespace Exercise_1_Calculator;

public class Calculator
{
    public string Input { get; set; } = "";
    private double _result = 0;
    public double Result
    {
        get => _result;
        private set => _result = value;
    }

    private void ApplyOperation (string numberString, char operatorChar)
    {
        double currentNumber = double.Parse(numberString);
        if (operatorChar == '\0')
        {
            _result = currentNumber;
        }
        else
        {
            switch(operatorChar)
            {
                case '+':
                    _result += currentNumber;
                    break;
                case '-':
                    _result -= currentNumber;
                    break;
                case '*':
                    _result *= currentNumber;
                    break;
                case '/':
                    _result /= currentNumber;
                    break;
                case '^':
                    _result = Math.Pow(_result, currentNumber);
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
        
        return _result;
    } 
}
