using Configurator.Model;
using Configurator.Model.Entities;
using Configurator.Pages;
using Configurator.ViewModel;
using System.Windows;

namespace Configurator
{

    public partial class MainWindow : Window
    {
        List<Device> devices;
        public MainWindow()
        {
            InitializeComponent();
            treeView1.ItemsSource = GetDeviceList();
            DeviceAddition.Notify += ReFillItems;
        }
        private void ReFillItems()
        {
            treeView1.ItemsSource = GetDeviceList();
        }
        private List<Device> GetDeviceList()
        {
            var Device = new DeviceViewModel();
            return Device.GetDevices();
        }
        private void ButtonClouse(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void OpenPage(object sender, RoutedEventArgs e)
        {
            FramePage.Content = new InfoPage();
        }

    }
}