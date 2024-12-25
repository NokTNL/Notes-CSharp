namespace Exercise_1_Calculator;

class Calculator
{
    public string RawInput = "";
    private double _result = 0;
    public double Result => _result;

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
        string rawInputWithoutSpace = RawInput.Replace(" ", "");
        string lastNumberString = "";
        char lastOperator = '\0';
        foreach (char currentChar in rawInputWithoutSpace)
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
            else throw new Exception();
        }
        ApplyOperation(lastNumberString, lastOperator);
        
        return _result;
    } 
}
