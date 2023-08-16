internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(CoincideixSumaPrecedents(new int[] { 1, 2, 3, 4, 5 }, 2, 4, 0));
    }

    static bool CoincideixSumaPrecedents(int[] v, int index, int final, int suma)
    {
        bool coincideix;
        coincideix = false;
        if (final < index) suma += v[final];
        else
        {
            coincideix = CoincideixSumaPrecedents(v, index, final - 1, suma);
            if (suma == v[index]) coincideix = true; 
        }
        return coincideix;
    }
}