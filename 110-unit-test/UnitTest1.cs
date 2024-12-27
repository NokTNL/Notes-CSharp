// A test project is typically separate from the project you want to test
using Exercise_1_Calculator;
// To create one: `dotnet new xunit -o <project-name>`
//  - Usually people will name it as something like `MyProject.Test`
// Then, you will need to add the target project as a dependency via this command:
//  - `dotnet add reference <path-to-dependent-project-.csproj>`
//  - This will add the project in the .csproj of this project
namespace _110_unit_test;

public class Calculator_Operations
{
    [Fact]
    public void Plus()
    {
        Calculator calculator = new();
        calculator.Input = "1 + 2";
        calculator.Calculate();
        Assert.Equal(3, calculator.Result);
    }
    [Fact]
    public void Minus()
    {
        Calculator calculator = new();
        calculator.Input = "9 - 7.5";
        calculator.Calculate();
        Assert.Equal(1.5, calculator.Result);
    }

    [Fact]
    public void Multiply()
    {
        Calculator calculator = new();
        calculator.Input = "1.2 * 6.0";
        calculator.Calculate();
        Assert.Equal(7.2, calculator.Result, 0.00001);
    }

    [Fact]
    public void Divide()
    {
        Calculator calculator = new();
        calculator.Input = "10 / 4";
        calculator.Calculate();
        Assert.Equal(2.5, calculator.Result, 0.00001);
    }

    [Fact]
    public void Power()
    {
        Calculator calculator = new();
        calculator.Input = "2 ^ 2.5";
        calculator.Calculate();
        Assert.Equal(5.65685, calculator.Result, 0.00001);
    }

    [Fact]
    public void Mixed()
    {
        Calculator calculator = new();
        calculator.Input = "2.3 - 6.5 * 9.81 + 31 / 7 ^ 4";
        calculator.Calculate();
        Assert.Equal(4.51179, calculator.Result, 0.00001);
    }
}

public class Calculator_Expressions_Formatting
{
    [Fact]
    public void Spaces_And_Dot_Notations()
    {
        Calculator calculator = new();
        calculator.Input = "   2.   *5+.1  ";
        calculator.Calculate();
        Assert.Equal(10.1, calculator.Result);
    }

    [Fact]
    public void Operator_End()
    {
        Calculator calculator = new();
        calculator.Input = "1 +";
        Assert.Throws<FormatException>(() => calculator.Calculate());
    }

    [Fact]
    public void Operator_Start()
    {
        Calculator calculator = new();
        calculator.Input = "* 7";
        Assert.Throws<FormatException>(() => calculator.Calculate());
    }

    [Fact]
    public void Operators_In_Series()
    {
        Calculator calculator = new();
        calculator.Input = "7^^2";
        Assert.Throws<FormatException>(() => calculator.Calculate());
    }

    [Fact]
    public void Dots_In_Series()
    {
        Calculator calculator = new();
        calculator.Input = "7..6";
        Assert.Throws<FormatException>(() => calculator.Calculate());
    }
    
}