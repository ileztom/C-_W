namespace KTR2
{
    internal class Program
    {
        static double SeriesSum(double epsilon)
        {
            double sum = 0;
            double term = 1;
            int n = 1;

            while (Math.Abs(term) >= epsilon)
            {
                sum += term;
                n++;
                term = Math.Pow(10, n) / Factorial(n);
            }

            return sum;
        }

        static double Factorial(int n)
        {
            if (n == 0)
                return 1;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            double epsilon = 1e-2;
            double sum = SeriesSum(epsilon);
            Console.WriteLine("Сумма ряда с точностью ε = 10^(-2): " + sum);
        }
    }
}
