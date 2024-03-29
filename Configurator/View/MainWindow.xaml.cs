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
            devices = storage.GetDevices();
            InitializeComponent();
            treeView1.ItemsSource = devices;
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