internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Maxim(new int[] { 1, 2, 3, 4, 5}));
    }

    static int Maxim(int[] valors)
    {
        return Maxim(valors, valors.Length);
    }

    static int Maxim(int[] valors, int n)
    {
        int maxim;
        if(n == 1) maxim = valors[0];
        else
        {
            maxim = Math.Max(valors[n - 1], n - 1);
        }
        return maxim;
    }
}