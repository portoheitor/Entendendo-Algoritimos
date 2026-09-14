namespace Cap02_OrdenacaoSelecao;

public static class SelectionSort
{
    public static int[] Sort(int[] array)
    {
        int[] cloneArray = (int[])array.Clone();
        int n = cloneArray.Length;

        for(int i = 0; i < n -1; i++)
        {
            int minIndex = i; 
            
            for(int j = i+1; j < n; j++)
            {
                if(cloneArray[j] < cloneArray[minIndex]) // compara o valor do indice atual com o menor valor
                {
                    minIndex = j; // atualiza o menor indice
                }
            }

            // troca o valor do menor indice com o valor do indice atual
            int temp = cloneArray[minIndex];   // guarda o menor valor encontrado
            cloneArray[minIndex] = cloneArray[i]; // manda o valor de i para a posição do menor
            cloneArray[i] = temp;               // coloca o menor valor na posição i
        }
        return cloneArray;
    }

}

  
