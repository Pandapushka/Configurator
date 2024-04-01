namespace Configurator.Model.Entities;

public static class DeviceAddition
{
    public delegate void DeviceHandler();
    public static event DeviceHandler Notify;
    public static void NewDeviceAdded()
    {
        Notify.Invoke();
        return;
    }
    public delegate void UpdateDeviceHandler();
    public static event UpdateDeviceHandler NotifyUpdateCom;
    public static void UpdateDeviceRemoved() 
    {
        NotifyUpdateCom.Invoke();
        return;
    }

}
