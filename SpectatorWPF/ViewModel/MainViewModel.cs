using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpectatorWPF.Core;

namespace SpectatorWPF.ViewModel
{
    class MainViewModel :ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public DeviceViewModel DeviceVM { get; set; }

        public MainViewModel()
        {
            DeviceVM = new DeviceViewModel();
            CurrentView = DeviceVM;
        }
    }
}
