using System.Diagnostics;

namespace deck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = RandomArray(20, 0, 20);
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            Stopwatch stopwatch = Stopwatch.StartNew();
            int swaps = SelectionSort(array);
            //int swaps = BubbleSort(array);
            stopwatch.Stop();

            Console.WriteLine("\nОтсортированный массив:");
            PrintArray(array);
            Console.WriteLine($"\nКоличество замен: {swaps}");
            Console.WriteLine($"Время выполнения сортировки: {stopwatch.Elapsed.TotalMilliseconds} мс");
        }

        static int[] RandomArray(int length, int min, int max)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int SelectionSort(int[] array)
        {
            int n = array.Length;
            int swaps = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                    swaps++;
                }
            }
            return swaps;
        }
        //static int BubbleSort(int[] array)
        //{
        //    int n = array.Length;
        //    int swaps = 0;
        //    bool swapped;
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        swapped = false;
        //        for (int j = 0; j < n - i - 1; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {

        //                int temp = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = temp;
        //                swapped = true;
        //                swaps++;
        //            }
        //        }
        //        if (!swapped)
        //            break;
        //    }
        //    return swaps;
        //}
    }
}