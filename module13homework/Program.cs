using System;

class Program
{
    static void Main()
    {
        var bankService = new BankService();

        while (true)
        {
            Console.WriteLine("\n1. Добавить клиента в очередь");
            Console.WriteLine("2. Обслужить следующего клиента");
            Console.WriteLine("3. Посмотреть статус очереди");
            Console.WriteLine("4. Посмотреть обслуженных клиентов");
            Console.WriteLine("5. Выйти");

            Console.Write("Введите ваш выбор: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    bankService.EnqueueClient();
                    break;
                case 2:
                    bankService.ServeNextClient();
                    break;
                case 3:
                    bankService.DisplayQueueStatus();
                    break;
                case 4:
                    bankService.DisplayServicedClients();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, попробуйте снова.");
                    break;
            }
        }
    }
}

class Client
{
    public string Name { get; }
    public string ServiceType { get; }

    public Client(string name, string serviceType)
    {
        Name = name;
        ServiceType = serviceType;
    }
}

class ClientQueue
{
    private Queue<Client> clients = new Queue<Client>();

    public void Enqueue(Client client)
    {
        clients.Enqueue(client);
    }

    public Client Dequeue()
    {
        return clients.Dequeue();
    }

    public bool Any()
    {
        return clients.Any();
    }

    public void DisplayQueueStatus()
    {
        if (clients.Any())
        {
            Console.WriteLine("Текущий статус очереди:");
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.Name} - {client.ServiceType}");
            }
        }
        else
        {
            Console.WriteLine("Очередь пуста.");
        }
    }
}

class BankService
{
    private ClientQueue clientQueue = new ClientQueue();
    private List<Client> servicedClients = new List<Client>();
    private Random random = new Random();

    public void EnqueueClient()
    {
        string clientName = Guid.NewGuid().ToString().Substring(0, 8); 
        string serviceType = GetRandomServiceType();

        Client newClient = new Client(clientName, serviceType);
        clientQueue.Enqueue(newClient);

        Console.WriteLine($"{newClient.Name} обслуживается по услуге {newClient.ServiceType}");
        clientQueue.DisplayQueueStatus();
    }

    public void ServeNextClient()
    {
        if (clientQueue.Any())
        {
            Client nextClient = clientQueue.Dequeue();
            servicedClients.Add(nextClient);

            Console.WriteLine($"{nextClient.Name} обслуживается по услуге {nextClient.ServiceType}.");
            clientQueue.DisplayQueueStatus();
        }
        else
        {
            Console.WriteLine("Очередь пуста. Нет клиентов для обслуживания.");
        }
    }

    public void DisplayQueueStatus()
    {
        clientQueue.DisplayQueueStatus();
    }

    public void DisplayServicedClients()
    {
        Console.WriteLine("Обслуженные клиенты:");
        foreach (var client in servicedClients)
        {
            Console.WriteLine($"{client.Name} - {client.ServiceType}");
        }
    }

    private string GetRandomServiceType()
    {
        string[] serviceTypes = { "Credit", "Deposit", "Consultation" };
        return serviceTypes[random.Next(serviceTypes.Length)];
    }
}
