namespace SM_Graf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //граф 1
            int[,] adjacencyMatrix1 = new int[,]
        {
            {0, 1, 1, 1, 1, 1, 1},
            {1, 0, 1, 0, 0, 0, 1},
            {1, 1, 0, 1, 0, 1, 0},
            {1, 0, 1, 0, 1, 0, 0},
            {1, 0, 0, 1, 0, 1, 0},
            {1, 0, 1, 0, 1, 0, 1},
            {1, 1, 0, 0, 0, 1, 0}
        };
            List<Tuple<int, int>> edgeList1 = new List<Tuple<int, int>>()
        {
            Tuple.Create(1, 2), Tuple.Create(1, 3), Tuple.Create(1, 4), Tuple.Create(1, 5), Tuple.Create(1, 6), Tuple.Create(1, 7),
            Tuple.Create(2, 3), Tuple.Create(2, 7),
            Tuple.Create(3, 4), Tuple.Create(3, 6),
            Tuple.Create(4, 5),
            Tuple.Create(5, 6),
            Tuple.Create(6, 7)
        };
            List<List<int>> adjacencyList1 = new List<List<int>>()
        {
            new List<int>() {2, 3, 4, 5, 6, 7},
            new List<int>() {1, 3, 7},
            new List<int>() {1, 2, 4, 6},
            new List<int>() {1, 3, 5},
            new List<int>() {1, 4, 6},
            new List<int>() {1, 3, 5, 7},
            new List<int>() {1, 2, 6}
        };
            Console.WriteLine("Матрица смежности для первого графа:");
            PrintMatrix(adjacencyMatrix1);

            Console.WriteLine("Список рёбер для первого графа:");
            PrintEdgeList(edgeList1);

            Console.WriteLine("Множество смежности для первого графа:");
            PrintAdjacencyList(adjacencyList1);
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
        static void PrintEdgeList(List<Tuple<int, int>> edgeList)
        {
            foreach (var edge in edgeList)
            {
                Console.WriteLine($"({edge.Item1}, {edge.Item2})");
            }
        }
        static void PrintAdjacencyList(List<List<int>> adjacencyList)
        {
            for (int i = 0; i < adjacencyList.Count; i++)
            {
                Console.Write($"{i + 1}: ");
                foreach (var neighbor in adjacencyList[i])
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
