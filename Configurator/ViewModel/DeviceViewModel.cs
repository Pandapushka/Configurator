using Configurator.DataService;
using Configurator.Model;
using Configurator.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Configurator.ViewModel
{
    internal class DeviceViewModel : INotifyPropertyChanged
    {

        public string Name { get; set; }
        public string TypeDevice { get; set; }
        public string Type { get; set; }
        public string Port { get; set; }
        public int Addres { get; set; }

        public ICommand IAddNewDevice => new RelayCommand(AddNewDevice);

        private readonly DeviseDataService _deviseDataService;

        private ObservableCollection<Device> _devices;

        public ObservableCollection<Device> Devices
        {
            get => _devices;
            set
            {
                _devices = value;
                OnPropertyChanged(nameof(Devices));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public DeviceViewModel()
        {
                _deviseDataService = new DeviseDataService();
        }

        private void LoadDevices()
        {
            var DeviceList = _deviseDataService.LoadDevices();
            Devices = new ObservableCollection<Device>(DeviceList);
        }
        public List<Device> GetDevices() 
        {
            var DeviceList = _deviseDataService.LoadDevices();
            return DeviceList;
        }

        public void AddNewDevice()
        {
            Device newDevice = new(Name, TypeDevice, Type, Port, Addres);
            _deviseDataService.AddDevice(newDevice);
            LoadDevices();
            DeviceAddition.NewDeviceAdded();
            DeviceAddition.UpdateDeviceRemoved();
        }

        public void UpdateDevice(Device updateDevice)
        {
            _deviseDataService.UpdateDevice(updateDevice);
            LoadDevices();
        }

        public void DeleteDevice(int deviseId)
        {
            _deviseDataService.DeleteDevise(deviseId);
            LoadDevices();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
