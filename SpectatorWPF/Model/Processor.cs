using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorWPF.Model
{
    public class Processor
    {
		private string? _name;
        private List<string> _parts;
		public string Name
		{
			get { return _name!; }
            private set 
            { 
                _name = value;
            }
		}

        public string Architecture { get; private set; }
        public string NumberOfCores { get; private set; }
        public string CurrentClockSpeed { get; private set; }
        public string L2CacheSize { get; private set; }
        public string L3CacheSize { get; private set; }


        public Processor()
        {
            _parts = Wmi.GetValues("root\\CIMV2", "Win32_Processor", new string[] { "Name", "AddressWidth", "NumberOfCores", "CurrentClockSpeed", "L2CacheSize", "L3CacheSize" });

            Name = _parts[0];
            Architecture = _parts[1];
            NumberOfCores = _parts[2];
            CurrentClockSpeed = _parts[3];
            L2CacheSize = _parts[4];
            L3CacheSize = _parts[5];
        }


    }
}
