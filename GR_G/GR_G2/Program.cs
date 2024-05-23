namespace GR_G2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> adjacencyList = new List<List<int>>()
        {
            new List<int>() {2, 6},
            new List<int>() {1, 3, 4, 5, 6, 8},
            new List<int>() {2, 8},
            new List<int>() {2, 5, 6, 7},
            new List<int>() {2, 4, 7, 8},
            new List<int>() {1, 2, 4, 7},
            new List<int>() {4, 5, 6, 8},
            new List<int>() {2, 3, 5, 7}
        };
            Console.WriteLine("Обход графа в глубину начиная с вершины 1:");
            bool[] visited = new bool[adjacencyList.Count];
            DFS(adjacencyList, 1, visited);
        }
        static void DFS(List<List<int>> adjacencyList, int currentVertex, bool[] visited)
        {
            visited[currentVertex - 1] = true;
            Console.Write(currentVertex + " ");
            foreach (var neighbor in adjacencyList[currentVertex - 1])
            {
                if (!visited[neighbor - 1])
                {
                    DFS(adjacencyList, neighbor, visited);
                }
            }
        }
    }
}
