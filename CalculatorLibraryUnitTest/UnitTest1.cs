namespace CalculatorLibraryUnitTest;
using CalculatorLibrary.Formulas;

public class UnitTest1
{
    [Fact]
    public void TestAddition()
    {
        int res = Basic.Addition(1, 1);
        Assert.Equal(res, 2);
    }

    [Fact]
    public void TestSubtraction()
    {
        int res = Basic.Subtraction(1, 1);
        Assert.Equal(res, 0);
    }

    [Fact]
    public void TestMultiplication()
    {
        int res = Basic.Multiplication(1, 1);
        Assert.Equal(res, 1);
    }

    [Fact]
    public void TestDivision()
    {
        decimal res = Basic.Division(1, 1);
        Assert.Equal(res, (decimal)1.0);
    }
}