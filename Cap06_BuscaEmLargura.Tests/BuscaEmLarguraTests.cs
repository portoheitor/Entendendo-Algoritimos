using Xunit;
using Cap06_BuscaEmLargura;
 
namespace Cap06_BuscaEmLargura.Tests;
 
public class BuscaEmLarguraTests
{
    [Fact]
    public void ExisteVendedorDeManga_QuandoHaVendedorNaRede_RetornaTrue()
    {
        // Arrange (grafo do livro: "thom" termina em "m", a 2 graus de distância)
        var grafo = new Dictionary<string, List<string>>
        {
            ["voce"]   = new List<string> { "alice", "bob", "claire" },
            ["bob"]    = new List<string> { "anuj", "peggy" },
            ["alice"]  = new List<string> { "peggy" },
            ["claire"] = new List<string> { "thom", "jonny" },
            ["anuj"]   = new List<string>(),
            ["peggy"]  = new List<string>(),
            ["thom"]   = new List<string>(),
            ["jonny"]  = new List<string>()
        };
 
        // Act
        bool resultado = BuscaEmLargura.ExisteVendedorDeManga(grafo, "voce");
 
        // Assert
        Assert.True(resultado);
    }
 
    [Fact]
    public void ExisteVendedorDeManga_QuandoNaoHaVendedorNaRede_RetornaFalse()
    {
        // Arrange (mesmo grafo, mas "thom" virou "thor": ninguém termina em "m")
        var grafo = new Dictionary<string, List<string>>
        {
            ["voce"]   = new List<string> { "alice", "bob", "claire" },
            ["bob"]    = new List<string> { "anuj", "peggy" },
            ["alice"]  = new List<string> { "peggy" },
            ["claire"] = new List<string> { "thor", "jonny" },
            ["anuj"]   = new List<string>(),
            ["peggy"]  = new List<string>(),
            ["thor"]   = new List<string>(),
            ["jonny"]  = new List<string>()
        };
 
        // Act
        bool resultado = BuscaEmLargura.ExisteVendedorDeManga(grafo, "voce");
 
        // Assert
        Assert.False(resultado);
    }
 
    [Fact]
    public void ExisteVendedorDeManga_QuandoGrafoTemCiclo_TerminaERetornaFalse()
    {
        // Arrange (voce -> ana -> voce -> ana ... sem o HashSet, isso nunca terminaria)
        var grafo = new Dictionary<string, List<string>>
        {
            ["voce"] = new List<string> { "ana" },
            ["ana"]  = new List<string> { "voce" }
        };
 
        // Act
        bool resultado = BuscaEmLargura.ExisteVendedorDeManga(grafo, "voce");
 
        // Assert
        Assert.False(resultado);
    }
 
    [Fact]
    public void ExisteVendedorDeManga_QuandoSoOPontoDePartidaTerminaEmM_RetornaFalse()
    {
        // Arrange ("tom" termina em "m", mas a pergunta é sobre a REDE dele, não sobre ele mesmo)
        var grafo = new Dictionary<string, List<string>>
        {
            ["tom"] = new List<string> { "ana" },
            ["ana"] = new List<string>()
        };
 
        // Act
        bool resultado = BuscaEmLargura.ExisteVendedorDeManga(grafo, "tom");
 
        // Assert
        Assert.False(resultado);
    }
 
    [Fact]
    public void ExisteVendedorDeManga_QuandoPontoDePartidaNaoTemVizinhos_RetornaFalse()
    {
        // Arrange
        var grafo = new Dictionary<string, List<string>>
        {
            ["voce"] = new List<string>()
        };
 
        // Act
        bool resultado = BuscaEmLargura.ExisteVendedorDeManga(grafo, "voce");
 
        // Assert
        Assert.False(resultado);
    }
}