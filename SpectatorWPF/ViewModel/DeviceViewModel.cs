using SpectatorWPF.Core;
using SpectatorWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorWPF.ViewModel
{
    class DeviceViewModel : ObservableObject
    {
        private string? manufacturer;

        public string? Manufacturer 
        { 
            get => manufacturer;
            set 
            { 
                manufacturer = value; 
                OnPropertyChanged(nameof(Manufacturer));
            }
        
        }

        private string? _model;

        public string? Model
        {
            get { return _model; }
            set 
            { 
                _model = value;
                OnPropertyChanged(nameof(Model));
            }
        }

        private string? _partNumber;

        public string? PartNumber
        {
            get { return _partNumber; }
            set 
            { 
                _partNumber = value; 
                OnPropertyChanged(nameof(PartNumber));
            }
        }
        private string? _serialnumber;

        public string? SerialNumber
        {
            get { return _serialnumber; }
            set 
            { 
                _serialnumber = value; 
                OnPropertyChanged(nameof(SerialNumber));
            }
        }




        public DeviceViewModel()
        {
            DeviceInfo device = new DeviceInfo();

            Manufacturer = device.Manufacturer;
            Model = device.Model;
            PartNumber= device.PartNumber;
            SerialNumber= device.SerialNumber;
        }
    }
}
