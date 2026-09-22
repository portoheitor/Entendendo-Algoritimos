using Xunit;
using Cap01_BuscaBinaria;

namespace Cap01_BuscaBinaria.Tests;

public class BinarySearchTheoryTests
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 }, 20, 9)]
    [InlineData(new int[] { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 }, 10, 5)]
    [InlineData(new int[] { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 }, 1 ,0)]
    [InlineData(new int[] { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 }, -1 ,-1)]
    [InlineData(new int[] { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 }, 0 ,-1)]
    [InlineData(new int[] { 1}, 1 ,0)]
    public void Search_QuandoTargetEstaNoArray_RetornaIndiceCorreto(int[] sortedArray , int target , int expectedIndex)
    {
        // Act
        int result = BinarySearch.Search(sortedArray , target);

        // Assert
        Assert.Equal(expectedIndex , result);
    }
}

