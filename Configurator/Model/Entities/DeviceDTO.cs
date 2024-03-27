using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurator.Model.Entities
{
    public static class DeviceDTO
    {
        public static string Name { get; private set; }
        public static string TypeDevice { get; private set; }
        public static string Type { get; private set; }
        public static string Port { get; private set; }
        public static int Addres { get; private set; }

        /// <summary> 
        /// Делегат обработки событий с девайсом 
        /// </summary> 
        public delegate void DeviceHandler();

        /// <summary> 
        /// Добавлен новый Девайс 
        /// </summary> 
        public static event DeviceHandler? DeviceAdd;

        /// <summary> 
        /// Проставить новый девайс 
        /// </summary> 
        /// <param name="newDeviceModel"></param> 
        public static void SetNewDevice(string name, string typeDev, string type, string port, int addres)
        {
            Name = name;
            TypeDevice = typeDev;
            Type = type;
            Port = port;
            Addres = addres;
            DeviceAdd?.Invoke();
            return;
        }
    }
}
