using CalculatorLibrary.Formulas;
using Xunit;

namespace CalculatorLibraryUnitTest;

public class UnitTest1
{
    [Fact]
    public void TestAddition()
    {
        int res = Basic.Addition(1, 1);
        Assert.Equal(2, res);
    }

    [Fact]
    public void TestSubtraction()
    {
        int res = Basic.Subtraction(1, 1);
        Assert.Equal(0, res);
    }

    [Fact]
    public void TestMultiplication()
    {
        int res = Basic.Multiplication(1, 1);
        Assert.Equal(1, res);
    }

    [Fact]
    public void TestDivision()
    {
        decimal res = Basic.Division(1, 1);
        Assert.Equal((decimal)1.0, res);
    }

    [Fact]
    public void TestDivisionZero()
    {
        Assert.Throws<Exception>(() => Basic.Division(1, 0));
    }
}