namespace HM10
{
    internal class Program
    {
        class Tariff
        {
            public string Name { get; set; }
            public double PricePerUnit { get; set; }
            public Tariff(string name, double pricePerUnit)
            {
                Name = name;
                PricePerUnit = pricePerUnit;
            }
        }
        // Класс, представляющий заказ на перевозку груза
        class Order
        {
            public string ClientName { get; set; }
            public double Volume { get; set; }
            public Tariff SelectedTariff { get; set; }
            public Order(string clientName, double volume, Tariff selectedTariff)
            {
                ClientName = clientName;
                Volume = volume;
                SelectedTariff = selectedTariff;
            }
            // Метод для вычисления стоимости заказа
            public double CalculateOrderCost()
            {
                return Volume * SelectedTariff.PricePerUnit;
            }
        }
        // Класс, представляющий узел двусвязного списка
        class Node
        {
            public Order Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public Node(Order order)
            {
                Data = order;
                Next = null;
                Previous = null;
            }
        }
        // Класс, представляющий двусвязный список заказов
        class OrderLinkedList
        {
            private Node head;
            private Node tail;
            // Метод для добавления заказа в конец списка
            public void AddOrder(Order order)
            {
                Node newNode = new Node(order);
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Previous = tail;
                    tail = newNode;
                }
            }
            // Метод для вывода суммы заказа для определенного клиента
            public double CalculateTotalOrderCostForClient(string clientName)
            {
                double totalCost = 0;
                Node current = head;
                while (current != null)
                {
                    if (current.Data.ClientName == clientName)
                    {
                        totalCost += current.Data.CalculateOrderCost();
                    }
                    current = current.Next;
                }
                return totalCost;
            }
            // Метод для подсчета суммарной стоимости всех заказов
            public double CalculateTotalOrderCost()
            {
                double totalCost = 0;
                Node current = head;
                while (current != null)
                {
                    totalCost += current.Data.CalculateOrderCost();
                    current = current.Next;
                }
                return totalCost;
            }
        }
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя ввод тарифов
            List<Tariff> tariffs = new List<Tariff>();
            Console.WriteLine("Введите информацию о тарифах (название и стоимость за единицу):");
            while (true)
            {
                Console.Write("Название тарифа (или введите 'готово' для завершения ввода): ");
                string tariffName = Console.ReadLine();
                if (tariffName.ToLower() == "готово")
                    break;
                Console.Write("Стоимость за единицу: ");
                double pricePerUnit;
                while (!double.TryParse(Console.ReadLine(), out pricePerUnit))
                {
                    Console.WriteLine("Неверный формат стоимости. Пожалуйста, введите число.");
                }
                tariffs.Add(new Tariff(tariffName, pricePerUnit));
            }
            // Создаем двусвязный список заказов
            OrderLinkedList orderList = new OrderLinkedList();
            // Создаем заказы
            while (true)
            {
                Console.Write("Введите имя клиента (или введите 'готово' для завершения ввода заказов): ");
                string clientName = Console.ReadLine();
                if (clientName.ToLower() == "готово")
                    break;
                Console.Write("Введите объем груза: ");
                double volume;
                while (!double.TryParse(Console.ReadLine(), out volume))
                {
                    Console.WriteLine("Неверный формат объема. Пожалуйста, введите число.");
                }
                Console.WriteLine("Выберите тариф для заказа:");
                for (int i = 0; i < tariffs.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tariffs[i].Name} - {tariffs[i].PricePerUnit} за единицу");
                }
                int selectedTariffIndex;
                while (true)
                {
                    Console.Write("Введите номер выбранного тарифа: ");
                    if (!int.TryParse(Console.ReadLine(), out selectedTariffIndex) || selectedTariffIndex < 1 || selectedTariffIndex > tariffs.Count)
                    {
                        Console.WriteLine("Неверный ввод. Пожалуйста, выберите номер из списка.");
                    }
                    else
                    {
                        break;
                    }
                }
                Tariff selectedTariff = tariffs[selectedTariffIndex - 1];
                Order order = new Order(clientName, volume, selectedTariff);
                orderList.AddOrder(order);
            }
            // Выводим суммарную стоимость всех заказов
            double totalCost = orderList.CalculateTotalOrderCost();
            Console.WriteLine($"Суммарная стоимость всех заказов: {totalCost}");
        }
    }
}