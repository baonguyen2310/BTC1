using BTC1.Module;
namespace tests;


public class UnitTest1
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 3)]
    [InlineData(3, 6)]
    public void Test_BT1(int n, int output)
    {
        int result = BT1.recursiveFn(n);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 5)]
    [InlineData(3,14)]
    public void Test_BT2(int n, int output)
    {
        int result = BT2.recursiveFn(n);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(1, 1.0f)]
    [InlineData(2, 1.5f)]
    [InlineData(3, 1.833333f)]
    public void Test_BT3(int n, float output, float epsilon = 1e-3f)
    {
        float result = BT3.recursiveFn(n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(1, 0.5f)]
    [InlineData(2, 0.75f)]
    [InlineData(3, 0.916667f)]
    public void Test_BT4(int n, float output, float epsilon = 1e-3f)
    {
        float result = BT4.recursiveFn(n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(1, 1.333333f)]
    [InlineData(2, 1.533333f)]
    [InlineData(3, 1.676190f)]
    public void Test_BT5(int n, float output, float epsilon = 1e-3f)
    {
        float result = BT5.recursiveFn(n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(1, 0.5f)]
    [InlineData(2, 0.666667f)]
    [InlineData(3, 0.75f)]
    public void Test_BT6(int n, float output, float epsilon = 1e-3f)
    {
        float result = BT6.recursiveFn(n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(1, 0.5f)]
    [InlineData(2, 1.166667f)]
    [InlineData(3, 1.916667f)]
    public void Test_BT7(int n, float output, float epsilon = 1e-3f)
    {
        float result = BT7.recursiveFn(n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(1, 1.25f)]
    [InlineData(2, 2.083333f)]
    [InlineData(3, 2.958333f)]
    public void Test_BT8(int n, float output, float epsilon = 1e-3f)
    {
        float result = BT8.recursiveFn(n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 6)]
    public void Test_BT9(int n, int output)
    {
        int result = BT9.recursiveFn(n);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(3, 1, 3)]
    [InlineData(3, 2, 9)]
    [InlineData(3, 3, 27)]
    public void Test_BT10(int x, int n, int output)
    {
        int result = BT10.recursiveFn(x, n);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 3)]
    [InlineData(3, 9)]
    public void Test_BT11(int n, int output)
    {
        int result = BT11.recursiveFn(n);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(3, 1, 3)]
    [InlineData(3, 2, 12)]
    [InlineData(3, 3, 39)]
    public void Test_BT12(int x, int n, int output)
    {
        int result = BT12.recursiveFn(x, n);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(3, 1, 9)]
    [InlineData(3, 2, 90)]
    [InlineData(3, 3, 819)]
    public void Test_BT13(int x, int n, int output)
    {
        int result = BT13.recursiveFn(x, n);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(3, 1, 30)]
    [InlineData(3, 2, 273)]
    [InlineData(3, 3, 2460)]
    public void Test_BT14(int x, int n, int output)
    {
        int result = BT14.recursiveFn(x, n);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(1, 1.0f)]
    [InlineData(2, 1.333333f)]
    [InlineData(3, 1.5f)]
    public void Test_BT15(int n, float output, float epsilon = 1e-3f)
    {
        float result = BT15.recursiveFn(n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(3, 1, 3.0f)]
    [InlineData(3, 2, 6.0f)]
    [InlineData(3, 3, 10.5f)]
    public void Test_BT16(int x, int n, float output, float epsilon = 1e-3f)
    {
        float result = BT16.recursiveFn(x, n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(3, 1, 3.0f)]
    [InlineData(3, 2, 7.5f)]
    [InlineData(3, 3, 12.0f)]
    public void Test_BT17(int x, int n, float output, float epsilon = 1e-3f)
    {
        float result = BT17.recursiveFn(x, n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(3, 1, 5.5f)]
    [InlineData(3, 2, 8.875f)]
    [InlineData(3, 3, 9.8875f)]
    public void Test_BT18(int x, int n, float output, float epsilon = 1e-3f)
    {
        float result = BT18.recursiveFn(x, n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(3, 1, 8.5f)]
    [InlineData(3, 2, 10.525f)]
    [InlineData(3, 3, 10.958929f)]
    public void Test_BT19(int x, int n, float output, float epsilon = 1e-3f)
    {
        float result = BT19.recursiveFn(x, n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(2, 1.8477590650225735)]
    public void Test_BT33(int n, double output, double epsilon = 1e-3)
    {
        double result = BT33.recursiveFn(n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(2, 1.5537739740300374)]
    public void Test_BT35(int n, double output, double epsilon = 1e-3)
    {
        double result = BT35.recursiveFn(n, n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }

    [Theory]
    [InlineData(2, 1.4142135623730951)]
    [InlineData(3, 1.6404051104084314)]
    public void Test_BT37(int n, double output, double epsilon = 1e-3)
    {
        double result = BT37.recursiveFn(n);
        Assert.True(Math.Abs(output - result) < epsilon);
    }
}