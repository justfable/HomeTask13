using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13
{
    public class QueueManager
    {
        private Queue<Client> clientQueue = new Queue<Client>();

        public void AddClientToQueue(Client client)
        {
            clientQueue.Enqueue(client);
            Console.WriteLine($"{client.Name} добавлен в очередь для услуги {client.ServiceType}.");
            ShowQueueState();
        }

        public Client ServeNextClient()
        {
            if (clientQueue.Count > 0)
            {
                Client clientToServe = clientQueue.Dequeue();
                Console.WriteLine($"{clientToServe.Name} обслуживается.");
                ShowQueueState();
                return clientToServe;
            }
            else
            {
                Console.WriteLine("Очередь пуста. Нет клиентов для обслуживания.");
                return null;
            }
        }

        public void ShowQueueState()
        {
            if (clientQueue.Count > 0)
            {
                Console.WriteLine("Текущее состояние очереди:");
                foreach (Client client in clientQueue)
                {
                    Console.WriteLine(client);
                }
            }
            else
            {
                Console.WriteLine("В очереди нет клиентов.");
            }
        }
    }

}
