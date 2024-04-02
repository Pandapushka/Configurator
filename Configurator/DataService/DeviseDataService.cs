using Configurator.Model;
using Newtonsoft.Json;
using System.IO;

namespace Configurator.DataService
{
    public class DeviseDataService
    {
        private readonly string _filePath;
        private readonly string folderName = "DeviceTurner";
        private readonly string fileName = "devices.Json";

        public DeviseDataService()
        {
           //Получаем полный путь к папке с данными
            string appDataPath = Environment.CurrentDirectory;
            string appFolder = Path.Combine(appDataPath, folderName);

            //Получаем папку с данными внутри приложения
            string dataFolder = Path.Combine(appFolder, fileName);

            // Если такой папки нет, то создаем ее
            if (!Directory.Exists(dataFolder))
            {
                Directory.CreateDirectory(dataFolder);
            }
            //Определяем путь к json файлу
            _filePath = Path.Combine(dataFolder, fileName);

            //Убедитесь, что файл json существует
            InitialezeFile(appDataPath);

        }

        private void InitialezeFile(string dataFolder)
        {
            if (!File.Exists(_filePath)) 
            {
                File.WriteAllText(_filePath, JsonConvert.SerializeObject(new List<Device>()));
            }

            //Process.Start(new ProcessStartInfo { FileName = dataFolder, UseShellExecute = true });
        }

        public List<Device> LoadDevices()
        {
            //Прочитать и десериализировать Json файл
            string fileContext = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Device>>(fileContext);
        }

        public void SaveDevices(List<Device> devices) 
        {
            //Сериализуем список задач и записываем в Json файл
            string json = JsonConvert.SerializeObject(devices, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public void AddDevice(Device newDevice)
        {
            //генерируем новый id
            newDevice.Id = GenerateNewDeviceId();
            //Загружаем список девайсов
            var devices = LoadDevices();
            //Добавляем девайс к списку 
            devices.Add(newDevice);
            //Сохраняем изиеннеия 
            SaveDevices(devices);
        }

        public void UpdateDevice(Device updateDevice) 
        {
            //Загружаем список девайсов из Json файла
            var devices = LoadDevices();
            // Находим нужный девайс
            var deviseIndex = devices.FindIndex(t => t.Id == updateDevice.Id);

            if (deviseIndex != -1) 
            {
                devices[deviseIndex] = updateDevice;
                SaveDevices(devices);
            }

        }

        public void DeleteDevise(int deviceId)
        {
            //Загружаем список девайсов из Json файла
            var devices = LoadDevices();
            //Удаляем нужный девайс по id
            devices.RemoveAll(t => t.Id == deviceId);
            //Сохраняем измененный список девайсов 
            SaveDevices(devices);
        }


        //генирируем уникальный id
        public int GenerateNewDeviceId()
        {
            var devices = LoadDevices();

            if(!devices.Any())
                return 1;
            int maxId = devices.Max(d => d.Id);
            return maxId + 1;
        }
    }
}
