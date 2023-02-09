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


        private object _currentView;
        private string testProperty;

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

        public RamViewModel RamVM { get; set; }
        public string TestProperty 
        {
            get => testProperty; 
            set
            {
                testProperty = value;
                OnPropertyChanged();

            }
        }

        //public RelayCommand DeviceViewCommand { get; set; }
        //public RelayCommand ProcessorViewCommand { get; set; }
        public MainViewModel()
        {
            TestProperty = "test";
            DeviceVM = new DeviceViewModel();
            CpuVM = new ProcessorViewModel();
            RamVM = new RamViewModel();
            CurrentView = RamVM;

            //DeviceViewCommand = new RelayCommand(o =>
            //{
            //    CurrentView = DeviceVM;
            //    TestProperty = "test2";
            //});

            //ProcessorViewCommand = new RelayCommand(o => CurrentView = CpuVM);

        }

        //private ICommand deviceViewCommand;
        //public ICommand DeviceViewCommand
        //{
        //    get
        //    {
        //        if (deviceViewCommand == null)
        //        {
        //            deviceViewCommand = new RelayCommand(argument =>
        //            {
        //                CurrentView = DeviceVM;
        //            });
        //        }
        //        return deviceViewCommand;
        //    }
        //}




    }
}
