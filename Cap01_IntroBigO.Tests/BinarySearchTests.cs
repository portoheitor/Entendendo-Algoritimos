using Xunit;
using Cap01_IntroBigO;

namespace Cap01_IntroBigO.Tests;

public class BinarySearchTests
{
    [Fact]
    public void Search_QuandoArrayTemUmUnicoElemento_RetornaIndiceCorreto()
    {
        // Arrange
        int[] sortedArray = { 5 };
        int target = 5;

        // Act
        int result = BinarySearch.Search(sortedArray, target);

        // Assert
        Assert.Equal(0 , result);
    }

    [Fact]
    public void Search_QuandoTargetEstaNoFinal_RetornaIndiceCorreto()
    {
        // Arrange
        int[] sortedArray = { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 };
        int target = 20;

        // Act
        int result = BinarySearch.Search(sortedArray, target);

        // Assert
        Assert.Equal(9 , result);
    }

    [Fact]
    public void Search_QuandoTargetEstaNoMeio_RetornaIndiceCorreto()
    {
        // Arrange
        int[] sortedArray = { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 };
        int target = 10;

        // Act
        int result = BinarySearch.Search(sortedArray, target);

        // Assert
        Assert.Equal(5 , result);
    }

    [Fact]
    public void Search_QundoTargetEstaNoPrimeiroIndice_RetornaIndiceCorreto()
    {
        // Arrange
        int[] sortedArray = { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 };
        int target = 1;

        // Act
        int result = BinarySearch.Search(sortedArray, target);

        // Assert
        Assert.Equal(0 , result);
    }

    [Fact]
    public void Search_QuandoTargetNaoExiste_RetornaMenosUm()
    {
        // Arrange
        int[] sortedArray = { 1, 3, 5, 7, 9, 10, 12, 15, 18, 20 };
        int target = 11;

        // Act
        int result = BinarySearch.Search(sortedArray, target);

        // Assert
        Assert.Equal(-1 , result);
    }

    [Fact]
    public void Search_ArrayValorNulo_RetornaMenosUm()
    {
        // Arrange
        int[] sortedArray = { };
        int? target = null;

        // Act
        int result = BinarySearch.Search(sortedArray, target);

        // Assert
        Assert.Equal(-1 , result);
    }
  
}