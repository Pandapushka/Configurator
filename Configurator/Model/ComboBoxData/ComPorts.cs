using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurator.Model.ComboBoxData
{
    public class ComPorts
    {
        /// <summary>
        /// Вернёт список ком портов
        /// </summary>
        /// <returns></returns>
        public List<string> GetComPortsList()
        {
            return new List<string>()
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
                "COM5",
                "COM6",
                "COM7",
                "COM8",
                "COM9",
                "COM10"
            };
        }
    }
}
