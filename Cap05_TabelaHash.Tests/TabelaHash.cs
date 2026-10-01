using Xunit;
using Cap05_TabelaHash;
using System.Reflection.Metadata.Ecma335;

namespace Cap05_TabelaHash.Tests;

public class TabelaHashDictionaryUsageTests
{
    [Theory]
    [InlineData(new int[]{10,20,30,40,50}, false)]
    [InlineData(new int[]{10,20,30,10,50}, true)]
    [InlineData(new int[]{}, false)]
    public void ContainsDuplicate_ShouldReturnExpectedResult(int[] inputArray, bool expectedResult)
    {
        // Act
        bool result = DictionaryUsage.ContainsDuplicate(inputArray);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}


/*#########################################################################################################################*/
/*#########################################################################################################################*/



public class TabelaHashTwoSumTests
{
    [Theory]
    [InlineData(new int[]{2,7,11,15}, 9, new int[]{0,1})]
    [InlineData(new int[]{3,2,4}, 6, new int[]{1,2})]
    [InlineData(new int[]{3,3}, 6, new int[]{0,1})]
    public void TwoSum_ShouldReturnExpectedResult(int[] inputArray, int target, int[] expectedResult)
    {
        // Act
        int[] result = DictionaryUsage.TwoSum(inputArray, target);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TwoSum_NaoEncontraSolucao_TargetNaoExiste()
    {
        // Arrange
        int[] inputArray = new int[]{1, 2, 3};
        int target = 7;

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => DictionaryUsage.TwoSum(inputArray, target));
        Assert.Equal("Não foi encontrado nenhum valor que somado a outro resultasse no valor do TARGET passado como parametro.", exception.Message);
    }


    /*#########################################################################################################################*/
    /*#########################################################################################################################*/



    public class HashTableImplementionHashTableTests
    {
        [Fact]
        public void AdicionarEBuscar_DeveAdicionarEBuscarValoresCorretamente()
        {
            // Arrange
            var hashTable = new HashTable(10);
            string chave1 = "chave1";
            int valor1 = 42;
            string chave2 = "chave2";
            int valor2 = 99;

            // Act
            hashTable.Adicionar(chave1, valor1);
            hashTable.Adicionar(chave2, valor2);

            // Assert
            Assert.Equal(valor1, hashTable.Buscar(chave1));
            Assert.Equal(valor2, hashTable.Buscar(chave2));
        }

        [Fact]
        public void Buscar_ChaveNaoExistente_DeveRetornarNull()
        {
            // Arrange
            var hashTable = new HashTable(10);
            string chaveInexistente = "chaveInexistente";

            // Act
            var resultado = hashTable.Buscar(chaveInexistente);

            // Assert
            Assert.Null(resultado);
        }

        [Fact]
        public void Adicionar_ChaveExistente_DeveAtualizarValor()
        {
            // Arrange
            var hashTable = new HashTable(10);
            string chaveExistente = "chaveExistente";
            int valorOriginal = 42;
            int novoValor = 99;

            // Act
            hashTable.Adicionar(chaveExistente, valorOriginal);
            hashTable.Adicionar(chaveExistente, novoValor);

            // Assert
            Assert.Equal(novoValor, hashTable.Buscar(chaveExistente));
        }

        [Fact]
        public void Adicionar_ChavesDiferentesComColisaoForcada_DeveArmazenarAmbasAsChaves()
        {
            // Arrange
            var hashTable = new HashTable(1); // Forçando colisão
            string chave1 = "chave1";
            int valor1 = 42;
            string chave2 = "chave2";
            int valor2 = 99;

            // Act
            hashTable.Adicionar(chave1, valor1);
            hashTable.Adicionar(chave2, valor2);

            // Assert
            Assert.Equal(valor1, hashTable.Buscar(chave1));
            Assert.Equal(valor2, hashTable.Buscar(chave2));
        }
    }

    /*#########################################################################################################################*/
    /*#########################################################################################################################*/
}
