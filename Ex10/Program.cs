internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(CapICua(new int[] { 1, 2, 3, 2, 1}, 0, 4));
    }

    static bool CapICua(int[] v, int inici, int final)
    {
        bool capicua;
        if(inici >= final) capicua = true;
        if (v[inici] == v[final]) capicua = CapICua(v, inici + 1, final - 1);
        else capicua = false;
        return capicua;
    }
}