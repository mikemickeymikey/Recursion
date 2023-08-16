internal class Program
{
    private static void Main(string[] args)
    {
        Invertir(1234);
    }

    static void Invertir(int n)
    {
        if (n < 10) Console.Write(n);
        else
        {
            Console.Write(n % 10);
            Invertir(n / 10);
        }
    }
}