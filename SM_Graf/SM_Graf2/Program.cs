namespace SM_Graf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] adjacencyMatrix2 = new int[,]
            {
            {0, 3, 4, 2, 7, 0, 0, 0},
            {3, 0, 4, 6, 0, 5, 3, 0},
            {4, 4, 0, 5, 0, 0, 0, 8},
            {2, 6, 5, 0, 7, 8, 0, 6},
            {7, 0, 0, 7, 0, 0, 4, 0},
            {0, 5, 0, 8, 0, 0, 7, 0},
            {0, 3, 0, 0, 4, 7, 0, 9},
            {0, 0, 8, 6, 0, 0, 9, 0}
            };
            List<Tuple<int, int, int>> edgeList2 = new List<Tuple<int, int, int>>()
        {
            Tuple.Create(1, 2, 3), Tuple.Create(1, 3, 4), Tuple.Create(1, 4, 2), Tuple.Create(1, 5, 7),
            Tuple.Create(2, 3, 4), Tuple.Create(2, 4, 6), Tuple.Create(2, 6, 5), Tuple.Create(2, 7, 3),
            Tuple.Create(3, 4, 5), Tuple.Create(3, 8, 8),
            Tuple.Create(4, 5, 7), Tuple.Create(4, 6, 8), Tuple.Create(4, 8, 6),
            Tuple.Create(5, 7, 4),
            Tuple.Create(6, 7, 7),
            Tuple.Create(7, 8, 9)
        };
            List<List<Tuple<int, int>>> adjacencyList2 = new List<List<Tuple<int, int>>>()
        {
            new List<Tuple<int, int>>() {Tuple.Create(2, 3), Tuple.Create(3, 4), Tuple.Create(4, 2), Tuple.Create(5, 7)}, // 1
            new List<Tuple<int, int>>() {Tuple.Create(1, 3), Tuple.Create(3, 4), Tuple.Create(4, 6), Tuple.Create(6, 5), Tuple.Create(7, 3)}, // 2
            new List<Tuple<int, int>>() {Tuple.Create(1, 4), Tuple.Create(2, 4), Tuple.Create(4, 5), Tuple.Create(8, 8)}, // 3
            new List<Tuple<int, int>>() {Tuple.Create(1, 2), Tuple.Create(2, 6), Tuple.Create(3, 5), Tuple.Create(5, 7), Tuple.Create(6, 8), Tuple.Create(8, 6)}, // 4
            new List<Tuple<int, int>>() {Tuple.Create(1, 7), Tuple.Create(4, 7), Tuple.Create(7, 4)}, // 5
            new List<Tuple<int, int>>() {Tuple.Create(2, 5), Tuple.Create(4, 8), Tuple.Create(7, 7)}, // 6
            new List<Tuple<int, int>>() {Tuple.Create(2, 3), Tuple.Create(5, 4), Tuple.Create(6, 7), Tuple.Create(8, 9)}, // 7
            new List<Tuple<int, int>>() {Tuple.Create(3, 8), Tuple.Create(4, 6), Tuple.Create(7, 9)} // 8
        };
            Console.WriteLine("Матрица смежности для второго графа:");
            PrintMatrix(adjacencyMatrix2);

            Console.WriteLine("Список рёбер для второго графа:");
            PrintEdgeList(edgeList2);

            Console.WriteLine("Множество смежности для второго графа:");
            PrintAdjacencyList(adjacencyList2);
        }
        static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintEdgeList(List<Tuple<int, int, int>> edgeList)
        {
            foreach (var edge in edgeList)
            {
                Console.WriteLine($"({edge.Item1}, {edge.Item2}, вес: {edge.Item3})");
            }
        }
        static void PrintAdjacencyList(List<List<Tuple<int, int>>> adjacencyList)
        {
            for (int i = 0; i < adjacencyList.Count; i++)
            {
                Console.Write($"{i + 1}: ");
                foreach (var neighbor in adjacencyList[i])
                {
                    Console.Write($"({neighbor.Item1}, вес: {neighbor.Item2}) ");
                }
                Console.WriteLine();
            }
        }
    }
}
