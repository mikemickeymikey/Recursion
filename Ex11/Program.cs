internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Ordenada(new int[] { 1, 2, 3, 4, 5}));
        Console.WriteLine(Ordenada(new int[] { 5, 4, 3, 2, 1 }));
        Console.WriteLine(Ordenada(new int[] { 1, 4, 5, 4, 5 }));
    }

    static bool Ordenada(int[] v)
    {
        return Ordenada(v, v.Length);
    }

    static bool Ordenada(int[] v, int n)
    {
        bool ordenada;
        if (n == 1 || n == 0) ordenada = true;
        else
        {
            if (v[n - 1] < v[n - 2])
            {
                ordenada = true;
                Ordenada(v, n - 1);
            }
            else if(v[n - 1] > v[n - 2])
            {
                ordenada = true;
                Ordenada(v, n - 1);
            }
            else ordenada = false; 
        }
        return ordenada;
    }
}