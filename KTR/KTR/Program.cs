namespace KTR
{
    internal class Program
    {
        static int F(int n)
        {
            if (n == 1)
                return 1;
            else if (n == 2)
                return 3;
            else
                return F(n - 1) * F(n - 2) + (n - 2);
        }
        static void Main(string[] args)
        {
            int result = F(5);
            Console.WriteLine("F(5) = " + result);
        }
    }
}