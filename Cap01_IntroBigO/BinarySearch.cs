namespace  Cap01_IntroBigO;

public static class BinarySearch
{
    public static int Search(int[] sortedArray, int? target)
    {
        int low = 0;
        int high = sortedArray.Length - 1;

        while(low <= high)
        {
            int mid = low + (high - low) / 2; // evitar overflow

            if(sortedArray[mid] == target)
            {
                return mid;
            }
            else if(sortedArray[mid] < target)
            {
                low = mid + 1; // se o valor do meio for menor que o alvo, busca na metade direita (adiciona 1 ao mid)
            }
            else
            {
                high = mid - 1; // se o valor do meio for maior que o alvo, busca na metade esquerda (subtrai 1 ao mid)
            }
        }
        return -1;
    }

    public static int SearchRecursive(int[] sortedArray, int? target, int low, int high)
    {
        if(low > high)
        {
            return -1; // caso base: não encontrado evita erros 
        } 

        int mid = low + (high - low) / 2; // evitar overflow

        if(sortedArray[mid] == target)
        {
            return mid;
        }
        else if(sortedArray[mid] < target)
        {
            return SearchRecursive(sortedArray, target, mid + 1, high); // se o valor do meio for menor que o alvo, busca na metade direita (adiciona 1 ao mid)
        }
        else
        {
            return SearchRecursive(sortedArray, target, low, mid - 1); // se o valor do meio for maior que o alvo, busca na metade esquerda (subtrai 1 ao mid)
        }
    }
}