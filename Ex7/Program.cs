internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(ProducteEscalar(0, 0, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }, 0));
    }

    static int ProducteEscalar(int n1, int n2, int[] v1, int[] v2, int i)
    {
        int resultat = 0;
        i = 0;
        if(v1.Length == 1 && v2.Length == 1) resultat = v1[0] * v2[0];
        else
        {
            resultat += n1 * n2;
            resultat += ProducteEscalar(v1[i], v2[i], v1, v2, i + 1);
        }
        return resultat;
    }
}