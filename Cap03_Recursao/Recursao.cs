
namespace Cap03_Recursao;

public static class Recursao
{
    public static long Fatorial(int n)
    {
        if(n < 0)
          throw new ArgumentException("O valor de n não pode ser negativo.");
          
        if (n == 0) // caso base
            return 1;
        else
            return n * Fatorial(n - 1); // chamada recursiva
    }


    public static long Fibonacci(int n)
    {
        if (n < 0)
           throw new ArgumentException("O valor de n não pode ser negativo.");

        if (n == 0) // caso base
            return 0;
        else if (n == 1) // caso base
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2); // chamada recursiva
    }
}



