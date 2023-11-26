using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13
{
    public class Client
    {
        public string ID { get; private set; }
        public string Name { get; set; }
        public string ServiceType { get; set; }

        public Client(string id, string name, string serviceType)
        {
            ID = id;
            Name = name;
            ServiceType = serviceType;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Service: {ServiceType}";
        }
    }

}
