namespace Cap04_Quicksort;

public static class Quicksort
{
    public static int[] Sort(int[] array)
    {
        int[] cloneArray = (int[])array.Clone();

        SortRecursive(cloneArray, 0, cloneArray.Length - 1);
        return cloneArray;
    }

    private static void SortRecursive(int[] array, int low, int high)
    {
        if(low < high) // caso base
        {
            int pivotIndex = Partition(array, low, high);
            SortRecursive(array, low, pivotIndex - 1); // Ordena a sublista à esquerda do pivô
            SortRecursive(array, pivotIndex + 1, high); // Ordena a sublista à direita do pivô
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot =  array[high]; // Ultimo Elemento é o pivo
        int i = low - 1;

        for(int j = low; j < high; j++)
        {
            if(array[j] <= pivot)
            {
                i++;
                int temp = array[i]; //troca posicao array[i] com array[j]
                array[i] = array[j];
                array[j] = temp;
            }
        }
        
        int temp2 = array[i + 1]; //troca posicao array[i+1] com array[high]
        array[i + 1] = array[high];
        array[high] = temp2;

        return i + 1;
    }
}