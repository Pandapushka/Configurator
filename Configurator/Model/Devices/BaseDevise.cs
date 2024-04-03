using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurator.Model.Devices
{
    public class BaseDevise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeDevice { get; set; }
        public string Type { get; set; }
        public string Port { get; set; }
        public int Addres { get; set; }
    }
}
