using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurator.Model.Lists
{
    public class Types
    {
        /// <summary>
        /// Вернёт список типов
        /// </summary>
        /// <returns></returns>
        public List<string> GetTypeList()
        {
            return new List<string>()
            {
                "Тип1",
                "Тип2",
                "Тип3"
            };
        }
    }
}
