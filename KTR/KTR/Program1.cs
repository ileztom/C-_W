namespace KTR
{
    internal class Program1
    {
        static int DigProduct(int n)
        {
            int product = 1;
            while (n != 0)
            {
                int digit = n % 10;
                product *= digit;
                n /= 10;
            }
            return product;
        }

        static void Main(string[] args)
        {
            int number = 12345;
            int result = DigProduct(number);
            Console.WriteLine("Произведение цифр числа " + number + " равно " + result);
        }
    }
}
