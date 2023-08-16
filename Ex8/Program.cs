internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Posicio(new int[] { 1, 2, 3, 4, 5 }, 3));
    }

    static int Posicio(int[] v, int n)
    {
        return Posicio(v, n, v.Length - 1);
    }

    static int Posicio(int[] v, int n, int final)
    {
        int posicio;
        if (final < 1) posicio = -1;
        else
        {
            if (v[final] == n) posicio = final;
            else posicio = Posicio(v, n, final - 1);
        }
        return posicio;
    }
}