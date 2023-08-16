internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Fibonacci(4));
    }

    static long Fibonacci(int num)
    {
        long resultat;
        if (num < 3) resultat = 1;
        else resultat = Fibonacci(num, 3, 1, 1);
        return resultat;
    }

    static long Fibonacci(int num, int index, long ultim, long penultim)
    {
        long resultat;
        if (index == num) resultat = ultim + penultim;
        else
        {
            resultat = Fibonacci(num, index + 1, ultim + penultim, ultim);
        }
        return resultat;
    }
}