namespace Z_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 1, 1, 1, 1, 4, 5 };
            int target = 1;

            int resultIndex = ModifiedBinarySearch(array, target);

            if (resultIndex != -1)
            {
                Console.WriteLine($"Первое вхождение {target} в массиве находится по индексу: {resultIndex}");
            }
            else
            {
                Console.WriteLine($"{target} не найдено в массиве.");
            }
        }

        static int ModifiedBinarySearch(int[] array, int target)
        {
            int low = 0;
            int high = array.Length - 1;
            int resultIndex = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == target)
                {
                    resultIndex = mid;
                    high = mid - 1;
                }
                else if (array[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return resultIndex;
        }
    }
}
