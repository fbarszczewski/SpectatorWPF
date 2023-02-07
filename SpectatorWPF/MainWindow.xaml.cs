using SpectatorWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpectatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> list = Wmi.GetValues("root\\CIMV2", "Win32_Processor", new string[] { "Caption", "Names", "NumberOfCores" });


            Processor processor = new Processor();


            MessageBox.Show($"{processor.Name} {processor.Architecture} {processor.NumberOfCores} {processor.CurrentClockSpeed} {processor.L2CacheSize} {processor.L3CacheSize}");
            //MessageBox.Show(Wmi.GetValue("root\\CIMV2", "Win32_Processor", "Names"));

        }
    }
}
