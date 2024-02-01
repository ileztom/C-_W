using System.Diagnostics;

namespace KT_S_ALG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySize = 10;
            double[] array = new double[arraySize];
            Console.Write("Массив - ");
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(1, 11);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            double result = PTT(array);
            Console.WriteLine("Произведение элементов между максимальным и минимальным " + result);
            Time(1000000);
        }
        static void Time(int n)
        {
            Random random = new Random();
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 11);
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            double result = PTT(array);
            stopwatch.Stop();
            Console.WriteLine($"N = {n}, Время выполнения {stopwatch.ElapsedMilliseconds} мс");
        }

        static double PTT(double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Массив не может быть пустым");
            }
            double maxElement = arr[0];
            double minElement = arr[0];
            int maxIndex = 0;
            int minIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                    maxIndex = i;
                }
                else if (arr[i] < minElement)
                {
                    minElement = arr[i];
                    minIndex = i;
                }
            }
            double product = 1;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                product *= arr[i];
            }
            return product;
        }
    }
}
