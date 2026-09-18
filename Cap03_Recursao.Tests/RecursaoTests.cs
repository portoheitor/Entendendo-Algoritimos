using Xunit;
using Cap03_Recursao;

namespace Cap03_Recursao.Tests;

public class RecursaoTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(10, 3628800)]
    [InlineData(15, 1307674368000)]

    public void TestFatorial(int n, long expected)
    {
        //Act
        long result = Recursao.Fatorial(n);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Fatorial_QuandoNumeroNegativo_LancaArgumentException()
    {
        var exception = Assert.Throws<ArgumentException>(() => Recursao.Fatorial(-1));
        Assert.Equal("O valor de n não pode ser negativo.", exception.Message);
    }




    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(10, 55)]
    [InlineData(15, 610)]

    public void TestFibonacci(int n, long expected)
    {
        //Act
        long result = Recursao.Fibonacci(n);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Fibonacci_QuandoNumeroNegativo_LancaArgumentException()
    {
        var exception = Assert.Throws<ArgumentException>(() => Recursao.Fibonacci(-1));
        Assert.Equal("O valor de n não pode ser negativo.", exception.Message);
    }
}