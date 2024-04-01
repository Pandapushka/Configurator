using Configurator.Model;
using Configurator.Model.Entities;
using Configurator.Pages;
using Configurator.ViewModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Configurator
{

    public partial class MainWindow : Window
    {
        private static int Id { get; set; }
        
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
            Button button = (Button)sender;
            var parameter = (Device)button.CommandParameter;
            Id = parameter.Id;
            FramePage.Content = new InfoPage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Id == 0)
            {
                MessageBox.Show("Не выбран прибор для удаления");
            }
            else 
            {
                MessageBox.Show(Id.ToString());
                DeviceViewModel deviceViewModel = new DeviceViewModel();
                deviceViewModel.DeleteDevice(Id);
                DeviceAddition.UpdateDeviceRemoved();

            }
        }
    }
}