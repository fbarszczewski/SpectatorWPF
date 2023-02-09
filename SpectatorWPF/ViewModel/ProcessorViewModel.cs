using SpectatorWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorWPF.ViewModel
{
    class ProcessorViewModel
    {

		private string _manufacturer;
        private string _model;

        public string Manufacturer
		{
			get { return _manufacturer; }
			set { _manufacturer = value; }
		}


		public string Model
		{
			get { return _model; }
			set { _model = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private string _architecture;

		public string Architecture
		{
			get { return _architecture; }
			set { _architecture = "x"+value; }
		}

		private int _cores;

		public int Cores
		{
			get { return _cores; }
			set { _cores = value; }
		}

		private string _speed;

		public string Speed
		{
			get { return _speed; }
			set { _speed = value; }
		}

		private int _l2Catche;

		public int L2Catche
		{
			get { return _l2Catche; }
			set { _l2Catche = value; }
		}

        private int _l3Catche;

        public int L3Catche
        {
            get { return _l3Catche; }
            set { _l3Catche = value; }
        }


		public ProcessorViewModel()
		{
			Processor processor = new Processor();
			Manufacturer = processor.Manufacturer;
			Model = processor.Name;
			Description = processor.Description;
			Architecture = processor.Architecture;
			Cores = ToIntConverter(processor.NumberOfCores);
			Speed = processor.CurrentClockSpeed;
			L2Catche = ToIntConverter(processor.L2CacheSize);
			L3Catche = ToIntConverter(processor.L3CacheSize);

        }


        private int ToIntConverter(string value)
		{
			int returnvalue = 0;
			int.TryParse(value, out returnvalue);

			return returnvalue;

		}



    }
}
