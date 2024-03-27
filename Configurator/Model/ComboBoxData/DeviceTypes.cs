namespace Configurator.Model.Lists
{
    public class DeviceTypes
    {
        /// <summary>
        /// Вернёт список типов устройств
        /// </summary>
        /// <returns></returns>
        public List<string> GetDeviceTypeList()
        {
            return new List<string>()
            {
                "ТипДевайса1",
                "ТипДевайса2",
                "ТипДевайса3"
            };
        }
    }
}
