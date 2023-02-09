using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpectatorWPF.Core;
using SpectatorWPF.Model;

namespace SpectatorWPF.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand DeviceViewCommand { get; set; }
        public RelayCommand ProcessorViewCommand { get; set; }

        private object _currentView;
        private string testProperty;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }
        public DeviceViewModel DeviceVM { get; set; }
        public ProcessorViewModel CpuVM { get; set; }

        public RamViewModel RamVM { get; set; }
        public string TestProperty 
        {
            get => testProperty; 
            set
            {
                testProperty = value;
                OnPropertyChanged("TestProperty");

            }
        }


        public MainViewModel()
        {
            TestProperty = "test";
            DeviceVM = new DeviceViewModel();
            CpuVM = new ProcessorViewModel();
            RamVM = new RamViewModel();
            CurrentView = RamVM;

            DeviceViewCommand = new RelayCommand(o =>
            {
                CurrentView = DeviceVM;
                TestProperty = "test2";
            });

            ProcessorViewCommand = new RelayCommand(o => CurrentView = CpuVM);

        }




    }
}
