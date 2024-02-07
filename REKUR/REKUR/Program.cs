namespace REKUR
{
    internal class Program
    {
        static int CalculateF(int n)
        {
            if (n <= 2)
            {
                return n + 3;
            }
            else
            {
                return CalculateF(n - 1) + CalculateF(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int result = CalculateF(a);
            Console.WriteLine($"F({a}) = {result}");
        }
    }
}
