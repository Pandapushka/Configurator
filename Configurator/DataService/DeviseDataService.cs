using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurator.DataService
{
    public class DeviseDataService
    {
        private readonly string _filePath;
        private readonly string folderName = "TaskTurner";
        private readonly string fileName = "devise.Json";

        public DeviseDataService()
        {
           //Получаем полный путь к папке с данными
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = Path.Combine(appDataPath, folderName);
            
        }
    }
}
