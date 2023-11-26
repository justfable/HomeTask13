using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13
{
    public class Program
    {
        static void Main(string[] args)
        {
            QueueManager queueManager = new QueueManager();
            UserInterface ui = new UserInterface(queueManager);
            ui.Start();
        }
    }
}
