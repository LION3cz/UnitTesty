using MyMathLibrary;

namespace XUnitTests;

public class UnitTest1
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(8, Class1.Add(5, 3));
    }

    [Fact]
    public void TestSubtract()
    {
        Assert.Equal(2, Class1.Subtract(5, 3));
    }
    [Fact]
    public void TestMultiply()
    {
        Assert.Equal(15, Class1.Multiply(5, 3));
    }
    [Fact]
    public void TestDivide()
    {
        Assert.Equal(2.0, Class1.Divide(6, 3));
    }
}