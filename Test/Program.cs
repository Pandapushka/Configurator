using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Test
{

    
    internal class Program
    {

        static void Main(string[] args)
        {
            XMLSetingsWriter writer = new XMLSetingsWriter();

            Device Device = new Device("name", "typeDev", "type", "port", 1);
            writer.AddXMLSetings(Device);
            Console.WriteLine("Тест");
            Console.ReadLine();
        }
    }
}
