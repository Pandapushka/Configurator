using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Test
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeDevice { get; set; }
        public string Type { get; set; }
        public string Port { get; set; }
        public int Addres { get; set; }

        public Device(string name, string typeDev, string type, string port, int addres)
        {
            Name = name;
            TypeDevice = typeDev;
            Type = type;
            Port = port;
            Addres = addres;

        }
        public Device()
        {
             
        }
    }
    public  class XMLSetingsWriter
    {
        XmlSerializer formatter = new XmlSerializer(typeof(List<Device>));
        public void AddXMLSetings(Device device)
        {
            var devices = LoadXMLSetings();
            devices.Add(device);
            SaveXMLSetings(devices);
        }
        public void SaveXMLSetings(List<Device> device) 
        {
            using (FileStream fs = new FileStream("setings.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, device);
            }
        }
        public List<Device> LoadXMLSetings()
        {
            List<Device> list = new List<Device>();
            if (!File.Exists("setings.xml"))
            {
                SaveXMLSetings(list);
            }
            else 
            {
                using (FileStream fs = new FileStream("setings.xml", FileMode.OpenOrCreate))
                {
                    int a = 0;
                    List<Device> devices = formatter.Deserialize(fs) as List<Device>;
                    if (devices != null)
                    {
                        foreach (Device device in devices)
                        {
                            list.Add(device);
                        }
                    }
                }
            }
            return list;
        }
    }
}
