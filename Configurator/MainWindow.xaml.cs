using Configurator.Model;
using Configurator.Pages;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Configurator
{
    
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            DeviseStorage storage = new DeviseStorage();
            List<Device> devices = storage.GetDevices();
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
            addDevicesWindow.ShowDialog();
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
    }
}