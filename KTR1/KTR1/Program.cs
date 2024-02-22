namespace KTR1
{
    internal class Program
    {
        static int FindMaxMultipleOf5(int[] arr, int left, int right)
        {
            if (left == right)
            {
                if (arr[left] % 5 == 0)
                    return arr[left];
                else
                    return int.MinValue;
            }

            int mid = (left + right) / 2;

            int maxLeft = FindMaxMultipleOf5(arr, left, mid);
            int maxRight = FindMaxMultipleOf5(arr, mid + 1, right);

            return Math.Max(maxLeft, maxRight);
        }

        static void Main(string[] args)
        {
            int[] arr = { 7, 10, 25, 15, 30, 12, 8, 20 };
            int maxMultipleOf5 = FindMaxMultipleOf5(arr, 0, arr.Length - 1);
            if (maxMultipleOf5 != int.MinValue)
                Console.WriteLine("Максимальный элемент, кратный 5: " + maxMultipleOf5);
            else
                Console.WriteLine("В массиве нет элементов, кратных 5.");
        }
    }
}
