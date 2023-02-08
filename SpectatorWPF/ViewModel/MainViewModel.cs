using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpectatorWPF.Core;

namespace SpectatorWPF.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand DeviceViewCommand { get; set; }
        public RelayCommand ProcessorViewCommand { get; set; }

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
        public ProcessorViewModel CpuVM { get; set; }

        public MainViewModel()
        {
            DeviceVM = new DeviceViewModel();
            CpuVM = new ProcessorViewModel();
            CurrentView = DeviceVM;

            DeviceViewCommand = new RelayCommand(o =>
            { 
                CurrentView= DeviceVM;
            });

            ProcessorViewCommand = new RelayCommand(o =>
            {
                CurrentView = CpuVM;
            });
        }




    }
}
