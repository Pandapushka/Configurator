using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurator.Model
{
    public class DeviseStorage
    {
        private List<Device> devices;
        public DeviseStorage()
        {
            devices = new List<Device>
            {
                new Device("ModBass1", "ТипДевайса1", "Тип1", 1, 1),
                new Device("ModBass2", "ТипДевайса2", "Тип2", 2, 2),
            };
        }

        public List<Device> GetDevices() 
        {
            return devices;
        }
    }
}
