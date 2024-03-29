using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Configurator.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand IOpenNewWindow => new RelayCommand(OpenAddNewDeviceWindow);
        public RelayCommand ICheckDevice => new RelayCommand(CheckDevices);
        public RelayCommand IDeleteDevices => new RelayCommand(DeleteDevices);
        public RelayCommand ISave => new RelayCommand(Save);

        private void OpenAddNewDeviceWindow()
        {
            AddDevicesWindow addDevicesWindow = new AddDevicesWindow();
            addDevicesWindow.ShowDialog();
        }
        private void DeleteDevices()
        {
            MessageBox.Show("Удалить");
        }
        private void CheckDevices()
        {
            MessageBox.Show("Проверить");
        }

        private void Save()
        {
            MessageBox.Show("Сохранить");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
