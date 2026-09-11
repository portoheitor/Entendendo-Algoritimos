using Xunit;
using Cap01_IntroBigO;  

namespace Cap01_IntroBigO.Tests;

public class BinarySearchRecursiveTests
{
    [Fact]
    public void SearchRecursive_QuandoTargetEstaNoFinal_RetornaIndiceCorreto()
    {
        // Arrange
        int[] sortedArray = { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 };
        int target = 20;

        // Act
        int result = BinarySearch.SearchRecursive(sortedArray, target, 0, sortedArray.Length - 1);

        // Assert
        Assert.Equal(9 , result);
    }

    [Fact]
    public void SearchRecursive_QuandoTargetEstaNoMeio_RetornaIndiceCorreto()
    {
        // Arrange
        int[] sortedArray = { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 };
        int target = 10;

        // Act
        int result = BinarySearch.SearchRecursive(sortedArray, target, 0, sortedArray.Length - 1);

        // Assert
        Assert.Equal(5 , result);
    }  

    [Fact]
    public void SearchRecursive_QundoTargetEstaNoPrimeiroIndice_RetornaIndiceCorreto()
    {
        // Arrange
        int[] sortedArray = { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 };
        int target = 1;

        // Act
        int result = BinarySearch.SearchRecursive(sortedArray, target, 0, sortedArray.Length - 1);

        // Assert
        Assert.Equal(0 , result);
    }

    [Fact]
    public void SearchRecursive_QuandoTargetNaoExiste_RetornaMenosUm()
    {
        // Arrange
        int[] sortedArray = { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 };
        int target = 11;

        // Act
        int result = BinarySearch.SearchRecursive(sortedArray, target, 0, sortedArray.Length - 1);

        // Assert
        Assert.Equal(-1 , result);
    }

    [Fact]
    public void SearchRecursive_QuandoArrayEstaVazio_RetornaMenosUm()
    {
        // Arrange
        int[] sortedArray = { };
        int target = 11;

        // Act
        int result = BinarySearch.SearchRecursive(sortedArray, target, 0, sortedArray.Length - 1);

        // Assert
        Assert.Equal(-1 , result);
    }

    [Fact]
    public void SearchRecursive_QuandoTargetEhNulo_RetornaMenosUm()
    {
        // Arrange
        int[] sortedArray = { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 };
        int? target = null;

        // Act
        int result = BinarySearch.SearchRecursive(sortedArray, target, 0, sortedArray.Length - 1);

        // Assert
        Assert.Equal(-1 , result);
    }
}   