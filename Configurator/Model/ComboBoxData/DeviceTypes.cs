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
                "flowmeter",
                "fakelevelmeter",
                "levelmeter",
                "ups",
                "counter",
                "fakecounter",
                "tempmodule",
                "bubbledetector",
                "io_module",
                "fakeGpsTracker",
                "tracker"
            };
        }
    }
}
