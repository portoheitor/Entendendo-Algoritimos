
using Xunit;
using Cap01_BuscaBinaria;

namespace Cap01_BuscaBinaria.Tests;

public class BinarySearchRecursiveTheoryTests
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 }, 20, 0, 9, 9)]
    [InlineData(new int[] { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 }, 10, 0, 9, 5)]
    [InlineData(new int[] { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 }, 1 ,0, 9, 0)]
    [InlineData(new int[] { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 }, -1 ,0, 9 ,-1)]
       [InlineData(new int[] { 1}, 1 ,0, 0, 0)]
    public void Search_QuandoTargetEstaNoArray_RetornaIndiceCorreto(int[] sortedArray , int target , int low, int high, int expectedIndex)
    {
        // Act
        int result = BinarySearch.SearchRecursive(sortedArray , target, low, high);

        // Assert
        Assert.Equal(expectedIndex , result);
    }
}