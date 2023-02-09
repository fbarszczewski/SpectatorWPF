using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SpectatorWPF.Core;
using SpectatorWPF.Model;

namespace SpectatorWPF.ViewModel
{
    class MainViewModel : ObservableObject
    {


        private object? _currentView;
        private string? testProperty;

        public object? CurrentView
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
        public RamViewModel RamVM { get; set; }


        public RelayCommand DeviceViewCommand { get; set; }
        public RelayCommand ProcessorViewCommand { get; set; }
        public RelayCommand RamViewCommand { get; set; }
        public MainViewModel()
        {

            DeviceVM = new DeviceViewModel();
            CpuVM = new ProcessorViewModel();
            RamVM = new RamViewModel();
            CurrentView = DeviceVM;

            DeviceViewCommand = new RelayCommand(o => CurrentView = DeviceVM);

            ProcessorViewCommand = new RelayCommand(o => CurrentView = CpuVM);
            RamViewCommand = new RelayCommand(o => CurrentView = RamVM);

        }





    }
}
