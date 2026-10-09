namespace Cap06_BuscaEmLargura;

public static class BuscaEmLargura
{
    public static bool ExisteVendedorDeManga(Dictionary<string, List<string>> grafo, string inicio)
    {
        Queue<string> fila = new Queue<string>();
        HashSet<string> verificadas = new HashSet<string>();

        // Povoar a Fila
        foreach (var item in grafo[inicio])
        {
            fila.Enqueue(item);
        }

        while (fila.Count > 0)
        {
            string pessoa = fila.Dequeue();

            //  Verifica se pessoa ja nao foi vista
            if(!verificadas.Add(pessoa))
                {
                    continue;
                }

            // verifica se a pessoa é o vendedor
            if (PessoaEVendedor(pessoa))
            {
                return true;
            }

            //  reorganiza os vizinhos na fila caso ele nao seja o vendedor        
            foreach (var item in grafo[pessoa])
            {
                fila.Enqueue(item);
            }

        }

        return false; // a fila esvaziou e ninguém era vendedor
    }
        

        //Regra do livro : "Quem tem o nome terminado com a letra "m" é o vendedor de mangas lembrando que a regra para definir o vendedor
        // pode ser alterada, a depender da necessidade, aqui é somente um exemplo seguido do livro, pois o intuito aqui é saber como o
        // algoritomo faz a busca se erradiar pelo grafo.

        private static bool PessoaEVendedor(string nome)
        {
            return nome.EndsWith('m');
        }
}


