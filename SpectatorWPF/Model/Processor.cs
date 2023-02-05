using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorWPF.Model
{
    internal class Processor
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string Architecture { get; set; }

        public string NumberOfCores { get; }

        public string CurrentClockSpeed { get; }

    }
}
