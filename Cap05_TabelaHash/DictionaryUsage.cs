namespace Cap05_TabelaHash;

public static class DictionaryUsage
{
    public static bool ContainsDuplicate(int[] nums)
    {
       HashSet<int> numerosVerificar = new HashSet<int>();

       foreach (var num in nums)
       {
            if(!numerosVerificar.Add(num))
            {
                return true;
            }
        }
       
       return false;
    }


    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> mapeamento = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complemento = target - nums[i]; // Valor necessario para atingir o Target (Valor Target - valor Atual)         

            if(mapeamento.ContainsKey(complemento))
            {
                return new int[]{mapeamento[complemento], i};
            }

            mapeamento[nums[i]] = i;
            
        }

        throw new ArgumentException("Não foi encontrado nenhum valor que somado a outro resultasse no valor do TARGET passado como parametro.");
    }

}
