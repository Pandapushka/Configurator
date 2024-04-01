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
        public int Id { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand IOpenNewWindow => new RelayCommand(OpenAddNewDeviceWindow);
        public RelayCommand ICheckDevice => new RelayCommand(CheckDevices);
        public RelayCommand IDeleteDevices => new RelayCommand(d =>DeleteDevices(Id));
        public RelayCommand ISave => new RelayCommand(Save);


        private void OpenAddNewDeviceWindow()
        {
            AddDevicesWindow addDevicesWindow = new AddDevicesWindow();
            addDevicesWindow.ShowDialog();
        }
        private void DeleteDevices(int deviceId)
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
