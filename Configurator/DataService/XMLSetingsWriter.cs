using Configurator.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Configurator.DataService
{
    public class XMLSetingsWriter
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
