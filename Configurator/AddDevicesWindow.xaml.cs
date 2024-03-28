using Configurator.Model.ComboBoxData;
using Configurator.Model.Entities;
using Configurator.Model.Lists;
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
            InitializeComponent();
            FillDeviceTypeComboBox();
            FillTypeComboBox();
            FiilComPortComboBox();
        }
        private void ButtonAddDevices(object sender, RoutedEventArgs e)
        {
            //Добавить валидацию
            DeviceDTO.SetNewDevice(ModelName.Text, DeviceTypeCB.Text, TypeCB.Text, ComPortCB.Text, Convert.ToInt32(Addres.Text));
            MessageBox.Show($"Добавить {ModelName.Text}");
            this.Close();
        }
        private void ButtonClouseWindow(object sender, RoutedEventArgs e)
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
