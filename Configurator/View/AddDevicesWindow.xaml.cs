using Configurator.Model.ComboBoxData;
using Configurator.Model.Entities;
using Configurator.Model.Lists;
using Configurator.ViewModel;
using System.Windows;

namespace Configurator
{
    /// <summary>
    /// Логика взаимодействия для AddDevicesWindow.xaml
    /// </summary>
    public partial class AddDevicesWindow : Window
    {

        public AddDevicesWindow()
        {
            DataContext = new DeviceViewModel();
            InitializeComponent();
            FillDeviceTypeComboBox();
            FillTypeComboBox();
            FiilComPortComboBox();
            DeviceAddition.NotifyUpdateCom += CloseWindow;
        }
       
        private void ButtonClouseWindow(object sender, RoutedEventArgs e)
        {
            CloseWindow();
        }

        public void CloseWindow()
        {
            this.Close();
        }

        private void FillDeviceTypeComboBox()
        {
            DeviceTypes dt = new();
            List<string> deviceTypes = dt.GetDeviceTypeList();
            DeviceTypeCB.ItemsSource = deviceTypes;
        }

        private void FillTypeComboBox()
        {
            Types t = new();
            List<string> types = t.GetTypeList();
            TypeCB.ItemsSource = types;
        }

        private void FiilComPortComboBox()
        {
            ComPorts cp = new();
            List<string> ports = cp.GetComPortsList();
            ComPortCB.ItemsSource = ports;
        }
    }
}
