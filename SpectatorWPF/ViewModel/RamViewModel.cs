using SpectatorWPF.Core;
using SpectatorWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectatorWPF.ViewModel
{
    internal class RamViewModel
    {
        private RAM ram;

        public string Location0
        {
			get { return ram.MemorySlots.Count > 0 ? ram.MemorySlots[0].Location : ""; }
		}

        public string Location1
        {
            get { return ram.MemorySlots.Count > 1 ? ram.MemorySlots[1].Location : ""; }
        }

        public string Location2
        {
            get { return ram.MemorySlots.Count > 2 ? ram.MemorySlots[2].Location : ""; }
        }

        public string Location3
        {
            get { return ram.MemorySlots.Count > 3 ? ram.MemorySlots[3].Location : ""; }
        }

        public string Manufacturer0
        {
            get { return ram.MemorySlots.Count > 0 ? ram.MemorySlots[0].Manufacturer : ""; }
        }

        public string Manufacturer1
        {
            get { return ram.MemorySlots.Count > 1 ? ram.MemorySlots[1].Manufacturer : ""; }
        }

        public string Manufacturer2
        {
            get { return ram.MemorySlots.Count > 2 ? ram.MemorySlots[2].Manufacturer : ""; }
        }
        public string Manufacturer3
        {
            get { return ram.MemorySlots.Count > 3 ? ram.MemorySlots[3].Manufacturer : ""; }
        }

        public string PartNumber0
        {
            get { return ram.MemorySlots.Count > 0 ? ram.MemorySlots[0].PartNumber : ""; }
        }

        public string PartNumber1
        {
            get { return ram.MemorySlots.Count > 1 ? ram.MemorySlots[1].PartNumber : ""; }
        }

        public string PartNumber2
        {
            get { return ram.MemorySlots.Count > 2 ? ram.MemorySlots[2].PartNumber : ""; }
        }

        public string PartNumber3
        {
            get { return ram.MemorySlots.Count > 3 ? ram.MemorySlots[3].PartNumber : ""; }
        }

        public int Size0
        {
            get { return ram.MemorySlots.Count > 0 ? ram.MemorySlots[0].Size : 0; }
        }

        public int Size1
        {
            get { return ram.MemorySlots.Count > 1 ? ram.MemorySlots[1].Size : 0; }
        }

        public int Size2
        {
            get { return ram.MemorySlots.Count > 2 ? ram.MemorySlots[2].Size : 0; }
        }

        public int Size3
        {
            get { return ram.MemorySlots.Count > 3 ? ram.MemorySlots[3].Size : 0; }
        }

        public uint Speed0
        {
            get { return ram.MemorySlots.Count > 0 ? ram.MemorySlots[0].ClockSpeed : 0; }
        }

        public uint Speed1
        {
            get { return ram.MemorySlots.Count > 1 ? ram.MemorySlots[1].ClockSpeed : 0; }
        }

        public uint Speed2
        {
            get { return ram.MemorySlots.Count > 2 ? ram.MemorySlots[2].ClockSpeed : 0; }
        }

        public uint Speed3
        {
            get { return ram.MemorySlots.Count > 3 ? ram.MemorySlots[3].ClockSpeed : 0; }
        }

        public uint Voltage0
        {
            get { return ram.MemorySlots.Count > 0 ? ram.MemorySlots[0].Voltage : 0; }
        }

        public uint Voltage1
        {
            get { return ram.MemorySlots.Count > 1 ? ram.MemorySlots[1].Voltage : 0; }
        }

        public uint Voltage2
        {
            get { return ram.MemorySlots.Count > 2 ? ram.MemorySlots[2].Voltage : 0; }
        }

        public uint Voltage3
        {
            get { return ram.MemorySlots.Count > 3 ? ram.MemorySlots[3].Voltage : 0; }
        }

        public RamViewModel()
        {
            ram= new RAM();
        }

    }
}
