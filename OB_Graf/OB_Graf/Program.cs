namespace OB_Graf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> adjacencyList = new List<List<int>>()
        {
            new List<int>() {2, 4, 5, 7},
            new List<int>() {1, 3, 6},
            new List<int>() {2, 4, 6, 7},
            new List<int>() {1, 3, 5},
            new List<int>() {1, 4, 6},
            new List<int>() {2, 3, 5, 7},
            new List<int>() {1, 3, 6}
        };
            Console.WriteLine("Обход первого графа в ширину");
            BFS(adjacencyList, 1);
        }
        static void BFS(List<List<int>> adjacencyList, int startVertex)
        {
            int n = adjacencyList.Count;
            bool[] visited = new bool[n];
            Queue<int> queue = new Queue<int>();
            visited[startVertex - 1] = true;
            queue.Enqueue(startVertex);
            while (queue.Count > 0)
            {
                int currentVertex = queue.Dequeue();
                Console.Write(currentVertex + " ");
                foreach (var neighbor in adjacencyList[currentVertex - 1])
                {
                    if (!visited[neighbor - 1])
                    {
                        visited[neighbor - 1] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
