

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("10", 10)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);    
    }

    [Theory]
    [InlineData("1,1", 2)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    public void AddsIntsSeperatedByCommas(string numbers, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);

    }

    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("1\n2,3", 6)]
    public void AddsIntsSeperatedByMixedDelimeter(string numbers, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);

    }
}
