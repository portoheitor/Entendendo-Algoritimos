using Xunit;
using Cap02_OrdenacaoSelecao;

namespace Cap02_OrdenacaoSelecao.Tests;

public class Cap02_OrdenacaoSelecaoTheoryTests
{
    [Theory]
    [InlineData(new int[] { 5, 3, 8, 1, 2 }, new int[] { 1, 2, 3, 5, 8 })]
    [InlineData(new int[] {-20, 0, 5, -10, 15}, new int[] {-20, -10, 0, 5, 15})]
    [InlineData(new int[] {1}, new int[] {1})]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 10, 9, 8, 7, 6 }, new int[] { 6, 7, 8, 9, 10 })]
    [InlineData(new int[] {1, 2, 3, 4, 4, 5}, new int[] {1, 2, 3, 4, 4, 5})]

    public void ResultadoEsperado_Sort(int[] input, int[] expected)
    {
        // Act
        int[] result = SelectionSort.Sort(input);

        // Assert
        Assert.Equal(expected, result);
    }
        
}