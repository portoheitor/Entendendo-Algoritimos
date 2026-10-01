namespace Cap05_TabelaHash;

public class HashTable
{
     private readonly int tamanho;
    private readonly List<(string chave, int valor)>[] buckets;

    public HashTable(int tamanho)
    {
        this.tamanho = tamanho;
        buckets = new List<(string chave, int valor)>[tamanho];
    }

    private int CalcularHash(string chave)
    {
        
        int valorLetra = 0;

        foreach (var letraString in chave)
        {
            valorLetra += letraString;
        }

        return valorLetra % tamanho;
    }

    public void Adicionar(string chave, int valor)
    {
       int indice = CalcularHash(chave);
   
       if(buckets[indice] == null)
        {
            buckets[indice] =new List<(string chave, int valor)>();
        }

        for (int i = 0; i < buckets[indice].Count; i++)
        {
           if(buckets[indice][i].chave == chave)
            {
                buckets[indice][i] = (chave, valor);
                return;
            }
        }
        
        buckets[indice].Add((chave, valor));
        
    }

    public int? Buscar(string chave)
    {
        int indice = CalcularHash(chave);
        
        if(buckets[indice] == null)
        {
            return null;
        }

        for (int i = 0; i < buckets[indice].Count; i++)
        {
            if(buckets[indice][i].chave == chave)
            {
                return buckets[indice][i].valor;
            }
        }

        return null;
    }
}
