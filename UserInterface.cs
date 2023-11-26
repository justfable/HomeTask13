using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13
{
    public class UserInterface
    {
        private QueueManager queueManager;

        public UserInterface(QueueManager queueManager)
        {
            this.queueManager = queueManager;
        }

        public void Start()
        {
            string userInput;
            do
            {
                Console.WriteLine("\nБанковская система управления очередью:");
                Console.WriteLine("1. Добавить клиента в очередь");
                Console.WriteLine("2. Обслужить следующего клиента");
                Console.WriteLine("3. Показать текущее состояние очереди");
                Console.WriteLine("4. Выйти");
                Console.Write("Выберите опцию: ");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddClient();
                        break;
                    case "2":
                        ServeClient();
                        break;
                    case "3":
                        ShowQueue();
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы...");
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод, пожалуйста, попробуйте снова.");
                        break;
                }
            } while (userInput != "4");
        }

        private void AddClient()
        {
            Console.Write("Введите ИИН клиента: ");
            string id = Console.ReadLine();
            Console.Write("Введите имя клиента: ");
            string name = Console.ReadLine();
            Console.Write("Введите тип услуги: ");
            string serviceType = Console.ReadLine();

            Client newClient = new Client(id, name, serviceType);
            queueManager.AddClientToQueue(newClient);
        }

        private void ServeClient()
        {
            Client servedClient = queueManager.ServeNextClient();
            if (servedClient != null)
            {
                Console.WriteLine($"Клиент {servedClient.Name} был обслужен.");
            }
        }

        private void ShowQueue()
        {
            queueManager.ShowQueueState();
        }
    }

}
