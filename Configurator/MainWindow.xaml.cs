using Configurator.Model;
using Configurator.Model.Entities;
using Configurator.Pages;
using System.Windows;

namespace Configurator
{

    public partial class MainWindow : Window
    {
        List<Device> devices;
        public MainWindow()
        {
            DeviseStorage storage = new DeviseStorage();
            DeviceDTO.DeviceAdd += AddDeviceToList;
            devices = storage.GetDevices();
            InitializeComponent();
            treeView1.ItemsSource = devices;
        }
        private void ButtonCheckDevices(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Проверить");
        }
        private void ButtonAddDevices(object sender, RoutedEventArgs e)
        {
            AddDevicesWindow addDevicesWindow = new AddDevicesWindow();
            addDevicesWindow.Show();
            this.Close();
        }
        private void ButtonDeleteDevices(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Удалить");
        }
        private void ButtonClouse(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Закрыть");
        }
        private void ButtonSave(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сохранить");
        }
        private void OpenPage(object sender, RoutedEventArgs e)
        {
            FramePage.Content = new InfoPage();
        }
        private void AddDeviceToList()
        {
            devices.Add(
                new Device
                (
                    DeviceDTO.Name,
                    DeviceDTO.TypeDevice,
                    DeviceDTO.Type,
                    DeviceDTO.Port,
                    DeviceDTO.Addres
                )
                ) ;
        }
    }
}