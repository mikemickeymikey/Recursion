internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(EsPrimer(4));
    }

    static bool EsPrimer(int n)
    {
        return EsPrimer(n, n / 2);
    }

    static bool EsPrimer(int n, int i)
    {
        bool primer;
        if (i == 1) primer = true;
        else
        {
            if (n % i == 0) primer = false;
            else return EsPrimer(n, i - 1);
        }
        return primer;
    }
}