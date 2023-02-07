using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorWPF.Model
{
    public class DeviceInfo
    {
        private string _manufacturer;
        private string _model;
        private string _serialNumber;

        public string Manufacturer
        {
            get => _manufacturer;
            private set => _manufacturer = value.Trim().ToUpper();
        }

        public string Model
        {
            get => _model;
            private set => _model = FormatModel(value);
        }

        public string PartNumber { get; }

        public string SerialNumber
        {
            get => _serialNumber;
            private set => _serialNumber = Manufacturer.Contains("LENOVO") ? $"S1{PartNumber}{value}" : value;
        }

        public DeviceInfo()
        {

            Manufacturer = "";
            Manufacturer = Wmi.GetValue("root\\CIMV2", "Win32_ComputerSystem", "Manufacturer");

            if (Manufacturer == "LENOVO")
            {
                Model = Wmi.GetValue("root\\CIMV2", "Win32_ComputerSystemProduct", "Version");
                PartNumber = Wmi.GetValue("root\\CIMV2", "Win32_ComputerSystem", "Model");
            }
            else
            {
                Model = Wmi.GetValue("root\\CIMV2", "Win32_ComputerSystem", "Model");
                PartNumber = Wmi.GetValue("root\\CIMV2", "Win32_ComputerSystemProduct", "Version");
            }


            SerialNumber = Wmi.GetValue("root\\CIMV2", "Win32_SystemEnclosure", "SerialNumber");
        }

        /// <summary>
        /// Formats model name string
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private string FormatModel(string model)
        {
            var modelSb = new StringBuilder(model);

            switch (Manufacturer)
            {
                case "LENOVO":
                    modelSb.Replace("ThinkPad", "");
                    modelSb.Replace("ThinkCentre", "");
                    break;

                case "DELL":
                    modelSb.Replace("Workstation", "");
                    modelSb.Replace("Precision", "");
                    modelSb.Replace("Latitude", "");
                    modelSb.Replace("OptiPlex", "");
                    modelSb.Replace("non-vPro", "");
                    modelSb.Replace("Inspiron", "");
                    modelSb.Replace("Vostro", "");
                    modelSb.Replace("AIO", "");
                    modelSb.Replace("Tower", "TWR");
                    break;

                case "HEWLETT-PACKARD":
                    modelSb.Replace("All-in-One", " AiO ");
                    modelSb.Replace("Workstation", "");
                    modelSb.Replace("EliteBook", "");
                    modelSb.Replace("Precision", "");
                    modelSb.Replace("EliteDesk", "");
                    modelSb.Replace("Notebook", "");
                    modelSb.Replace("ProBook", "");
                    modelSb.Replace("Spectre", "");
                    modelSb.Replace("Compaq", "");
                    modelSb.Replace("COMPAQ", "");
                    modelSb.Replace("Elite", "");
                    modelSb.Replace("Folio", "");
                    modelSb.Replace("Pro", "");
                    modelSb.Replace("HP", "");
                    modelSb.Replace("PC", "");
                    break;
            }

            return modelSb.ToString().Trim();
        }

    }
}
