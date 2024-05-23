namespace GR_G
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
            Console.WriteLine("Обход графа в глубину");
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
