namespace kolcev_sp
{
    class Node
    {
        public string Data;
        public Node Next;

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
    class CircularLinkedList
    {
        private Node head;
        private Node tail;
        public CircularLinkedList()
        {
            head = null;
            tail = null;
        }
        public void Add(string data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                newNode.Next = head;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                tail.Next = head;
            }
        }
        public void DrawLots(int step)
        {
            if (head == null)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            Node current = head;
            int count = 1;

            do
            {
                if (count % step == 0)
                {
                    Console.WriteLine(current.Data);
                }
                current = current.Next;
                count++;
            } while (current != head);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList team1 = new CircularLinkedList();
            team1.Add("Томов");
            team1.Add("Хорлин");
            team1.Add("Запевалов");
            team1.Add("Алейниченко");
            team1.Add("Баширов");

            CircularLinkedList team2 = new CircularLinkedList();
            team2.Add("Нвогородов");
            team2.Add("Васильев");
            team2.Add("Сорокин");
            team2.Add("Щаников");
            team2.Add("Зарали");

            int n = 3;
            int m = 3;

            Console.WriteLine("Команда 1");
            team1.DrawLots(n);
            Console.WriteLine("Команда 2");
            team2.DrawLots(m);
        }
    }
}
