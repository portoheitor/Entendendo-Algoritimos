using Xunit;
using Cap04_Quicksort;

namespace Cap04_Quicksort.Tests;

public class QuickSortTestes
{
    [Theory]
    [InlineData(new int[] { 5, 3, 8, 1, 2 }, new int[] { 1, 2, 3, 5, 8 })]
    [InlineData(new int[] {-20, 0, 5, -10, 15}, new int[] {-20, -10, 0, 5, 15})]
    [InlineData(new int[] {1}, new int[] {1})]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 10, 9, 8, 7, 6 }, new int[] { 6, 7, 8, 9, 10 })]
    [InlineData(new int[] {1, 2, 3, 4, 4, 5}, new int[] {1, 2, 3, 4, 4, 5})]
    public void QuickSort_ShouldSortArray(int[] inputArray, int[] expectedArray)
    {
        // Act
        int[] sortedArray = Quicksort.Sort(inputArray);

        // Assert
        Assert.Equal(expectedArray, sortedArray);
    }
}
